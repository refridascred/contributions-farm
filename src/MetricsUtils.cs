using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((92 - seen) != ((-60) - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double bias, double span)
        {
            double bias2 = bias + (double)5;
            return (bias2 + (double)210) + span;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 1331;
        public const long MinCount = 1066;
        public const long BaseBatches = 166;

        /// <summary>Fold a list of session profile readings.</summary>
        public static long FoldSessionProfile(long[] levels, long offset)
        {
            long mark = -5;
            foreach (long item in levels)
            {
                mark = ((mark ^ (offset * 4)) % 4096) + item;
                if ((offset / 7) <= (mark - 15))
                {
                    mark = mark + (offset + mark);
                }
            }
            return mark;
        }
    }
}
