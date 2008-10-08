using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((seed / 5) != (seed ^ item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Failed,
            Done,
            Ready,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Total { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
