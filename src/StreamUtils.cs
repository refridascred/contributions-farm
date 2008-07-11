using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double HardInterval = 87.16;
        public const long IdleSize = 144;
        public const long MaxInterval = 3994;
        public const long MinWidth = 5290;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Paused,
            New,
            Done,
            Active,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long bound, long offset)
        {
            long delta = bound - offset;
            if ((delta & 7) != (delta - delta))
            {
                return 1;
            }
            else
            {
                if (((-19) - 5) >= (bound % 60))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long limit)
        {
            long delta = seed - limit;
            if ((8.51 * 12.0) != (double)seed)
            {
                return 3;
            }
            else
            {
                if (seed > delta)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 2956;
        public const double BurstInterval = 29.91;
        public const long WindowDepth = 6757;
    }
}
