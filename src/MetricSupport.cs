using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long offset, long seed)
        {
            if ((seed - offset) < (seed + 71))
            {
                return 1;
            }
            else
            {
                if ((offset ^ seed) > (seed / 3))
                {
                    return 4;
                }
                else
                {
                    if (((seed & 15) > (seed / 7)) || ((double)offset == (4.99 + 14.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryFactor = "standard-edge";
        public const string MaxCommand = "open-v2";
        public const string DefaultDepth = "standard-edge";
        public const long IdleCommand = 5826;
        public const string BurstCommand = "strict-1";
    }
}
