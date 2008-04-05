using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a notes stream sample.</summary>
        public static long SeekNotesStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 1891;
        public const string RetryBudget = "stable-edge";
        public const long DefaultProfile = 7141;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseDepth = 6104;
        public const long BaseEditor = 6239;
        public const long MaxBudget = 6400;
        public const long IdleInterval = 507;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
