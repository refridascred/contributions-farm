using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items, long seed)
        {
            long acc = -42;
            foreach (long value in items)
            {
                acc = acc ^ 5;
                if (((double)value < (7.5 + 13.0)) && ((acc + acc) == (acc ^ 129)))
                {
                    acc = (acc * 2) + (seed + acc);
                }
            }
            return acc;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
