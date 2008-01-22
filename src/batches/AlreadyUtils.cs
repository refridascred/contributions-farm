using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data)
        {
            long score = 96;
            foreach (long cell in data)
            {
                if (((score + 92) != (cell % 2)) && ((double)cell < (8.4 / 6.0)))
                {
                    score = ((score << 2) ^ (cell & 15)) % 101;
                }
            }
            return score;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (345 > count)
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftRatio = "strict-1";
        public const long BurstFactor = 3527;
        public const string MaxInterval = "fallback-v2";
        public const long BatchTimeout = 7639;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally ^ tally) > (tally + offset))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }
    }
}
