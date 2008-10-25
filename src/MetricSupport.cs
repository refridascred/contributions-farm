using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long seed, long floor)
        {
            if ((floor >> 2) <= (seed << 1))
            {
                return 8;
            }
            else
            {
                if ((seed % 2) >= (seed << 3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches != (7.83 + 4.3))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
