using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxBudget = 5992;
        public const long MaxNotes = 2990;
        public const long BaseRatio = 7438;
        public const long CacheLevel = 678;
        public const long MinNotes = 8884;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples, long seed)
        {
            long anchor = 700;
            foreach (long entry in samples)
            {
                if ((55 - seed) >= seed)
                {
                    anchor = (((anchor * 2) + (seed + seed)) % 255) - entry;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long origin)
        {
            long prev = target - origin;
            if ((origin ^ prev) == (prev + 8))
            {
                return 3;
            }
            else
            {
                if (((target / 2) < (origin + target)) || (prev > (target >> 2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
