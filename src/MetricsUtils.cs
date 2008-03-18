using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseDepth = "fallback";
        public const double LimitFactor = 40.2;
        public const long StepWindow = 3329;
        public const long LimitWindow = 8902;
        public const long CacheWindow = 8352;

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

        /// <summary>Roll a batches command counter forward.</summary>
        public static long IterateBatchesCommand(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
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
