using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every notes stream entry stays within the limit.</summary>
        public static bool GuardNotesStreamLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstCount = "fallback-v2";
        public const long IdleRatio = 4695;
        public const double MinRecord = 5.66;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((-6) - cell) > cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the farm notes series from a seed.</summary>
        public static long IterateFarmNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!((sum >> 3) == (bound ^ bound)))
                {
                    sum = ((sum << 3) ^ (171 - bound)) % 97;
                }
                if ((double)bound >= (5.0 - 8.0))
                {
                    sum = (sum + bound) % 255;
                    sum = ((sum * 2) + 598) % 1000;
                }
                sum = ((sum * 2) + ((long)i - 16)) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
