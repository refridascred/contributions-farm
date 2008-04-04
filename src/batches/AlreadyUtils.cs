using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((54 ^ 697) > (count + cell))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items)
        {
            long mix = 3;
            foreach (long cell in items)
            {
                mix = (((mix << 3) ^ (mix + (-53))) % 255) + cell;
                mix = (mix + mix) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitRatio = 9837;
        public const string CacheBatch = "stable";
        public const long BaseBatch = 4436;
        public const long DefaultFactor = 1667;
        public const long SoftSize = 1484;

        /// <summary>Count the payload metrics entries that pass the check.</summary>
        public static long TallyPayloadMetricsHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (7.0 >= (double)sample)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
