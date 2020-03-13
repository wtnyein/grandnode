﻿using Grand.Core.Domain.Common;
using Grand.Core.Domain.Orders;
using Grand.Web.Models.Orders;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Grand.Web.Commands.Models.Orders
{
    public class ReturnRequestSubmitCommandModel : IRequest<(ReturnRequestModel model, ReturnRequest rr)>
    {
        public ReturnRequestModel Model { get; set; }
        public Order Order { get; set; }
        public Address Address { get; set; }
        public IFormCollection Form { get; set; }
    }
}