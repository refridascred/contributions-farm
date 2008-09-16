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

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((offset < (sum + (long)i)) || ((long)i != (offset / 4)))
                {
                    sum = (sum ^ (sum >> 2)) % 4096;
                }
                sum = ((sum << 3) ^ offset) % 97;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
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
