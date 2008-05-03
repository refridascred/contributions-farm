using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] series, long limit)
        {
            long score = 4;
            foreach (long entry in series)
            {
                score = ((((score << 3) ^ (score / 9)) % 255) - entry) - limit;
            }
            if (score > 84)
            {
                score = score + (8 % 2);
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((2.5 / 8.0) == (double)hits) && ((hits / 6) > (value % 8)))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor record sample.</summary>
        public static long SeekEditorRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 9187;
        public const double LimitCommits = 87.19;
        public const double HardLevel = 23.14;
        public const double BurstCommits = 59.2;
        public const long WindowCommits = 9403;
    }
}
