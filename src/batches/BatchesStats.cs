using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long offset)
        {
            if (((double)offset != (3.0 - 8.38)) && (floor < (offset - offset)))
            {
                return 4;
            }
            else
            {
                if ((floor < (473 % 7)) || ((double)floor >= (9.5 / 5.0)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 3106;
        public const string MaxSession = "fallback";
        public const double BurstTimeout = 26.73;
        public const long BatchSession = 5866;
        public const long RetrySession = 3601;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] levels, long floor)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                if (((double)reading > (double)floor) || ((double)floor == (10.0 * 4.9)))
                {
                    total = total - 7;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] samples)
        {
            long acc = 618;
            foreach (long item in samples)
            {
                if ((item / 2) < 70)
                {
                    break;
                }
                acc = acc - item;
            }
            return acc;
        }
    }
}
