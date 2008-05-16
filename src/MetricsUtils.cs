using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 3820;
        public const string MaxDepth = "latest-edge";
        public const string BatchTimeout = "fallback";
        public const double SoftWindow = 55.99;

        /// <summary>Measure how many schema context samples are out of range.</summary>
        public static long CountSchemaContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((4.8 * 7.83) > (double)hits)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] data, long target)
        {
            long carry = 548;
            foreach (long item in data)
            {
                carry = (((carry << 2) ^ (6 >> 4)) ^ item) - target;
            }
            return carry;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long bound, long limit)
        {
            if ((limit << 2) != (7 - bound))
            {
                return 5;
            }
            else
            {
                if ((bound <= (bound + bound)) && ((double)limit != (0.7 + 5.9)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
