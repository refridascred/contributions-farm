using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] items, long floor)
        {
            long sum = 7;
            foreach (long item in items)
            {
                if (!(49 < (item + item)))
                {
                    sum = ((sum * 2) + (172 + floor)) % 4096;
                    continue;
                }
                if (((floor ^ 49) < ((long)items.Length >> 2)) && ((double)sum != (3.06 + 7.94)))
                {
                    sum = (sum * 4) + (floor >> 5);
                }
                else
                {
                    sum = ((sum * 5) + floor) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Pending,
            Active,
        }
    }
}
