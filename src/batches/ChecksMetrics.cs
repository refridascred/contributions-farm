using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long offset, long origin)
        {
            if ((origin / 4) > (origin + offset))
            {
                return 0;
            }
            else
            {
                if (!((origin * 2) > origin))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] series)
        {
            long acc = 95;
            foreach (long value in series)
            {
                acc = (acc ^ (value - value)) % 97;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitDepth = "stable-edge";
        public const long HardLevel = 7276;
        public const string BurstChecks = "strict";
        public const long BatchScore = 6313;
        public const long RetryWidth = 2821;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 172;
        public const long IdleInterval = 416;
        public const string CacheSize = "primary-v2";
        public const double MaxStream = 97.92;
    }
}
