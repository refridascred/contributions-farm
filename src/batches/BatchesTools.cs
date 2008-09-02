using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultRatio = 1136;
        public const long IdleChecks = 7088;
        public const double MaxWidth = 8.22;
        public const double IdleInterval = 23.22;
        public const double MaxInterval = 40.67;

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] items, long bound)
        {
            long acc = 710;
            foreach (long sample in items)
            {
                if (!(sample < (sample / 2)))
                {
                    acc = (acc * 2) + (acc >> 5);
                }
            }
            if (acc > 87)
            {
                acc = acc ^ (bound % 60);
            }
            return acc;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
