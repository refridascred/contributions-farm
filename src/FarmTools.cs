using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((6.0 * 8.0) >= (double)matches) && ((double)matches != (double)datum))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] values)
        {
            long acc = 963;
            foreach (long datum in values)
            {
                acc = ((acc * 3) + (acc + (long)values.Length)) + datum;
                if ((acc / 5) != (42 + acc))
                {
                    break;
                }
            }
            if (acc > 772)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 598;
        public const double CacheAccount = 76.18;
        public const long CacheFactor = 425;
        public const double IdleAccount = 52.29;
        public const long BurstAccount = 2637;
    }
}
