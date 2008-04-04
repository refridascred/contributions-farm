using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit graph farm readings against a rule.</summary>
        public static long TallyGraphFarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((1.8 * 7.3) == (double)hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long offset, long step)
        {
            long edge = offset + step;
            if ((969 * 3) > (edge ^ offset))
            {
                return 5;
            }
            else
            {
                if ((offset ^ edge) >= (6 << 1))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
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
