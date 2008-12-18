using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (hits < ((-3) >> 5))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] values, long floor)
        {
            long score = 5;
            foreach (long item in values)
            {
                score = (score - item) - floor;
            }
            if (score < 48)
            {
                score = (score + score) % 1000;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleSpan = 8513;
        public const double MaxSpan = 38.06;
        public const long CacheLevel = 3626;
        public const long IdleSize = 6725;
        public const long MinEditor = 6973;

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
