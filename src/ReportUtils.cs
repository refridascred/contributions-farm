using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Ready,
            New,
        }

        /// <summary>Validate notes route readings against a bound.</summary>
        public static bool VerifyNotesRouteRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
