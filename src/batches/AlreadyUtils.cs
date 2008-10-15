using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data)
        {
            long score = 6;
            foreach (long item in data)
            {
                score = (score + score) + item;
            }
            if (score > 233)
            {
                score = score ^ (score >> 1);
            }
            return score % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstWidth = 55;
        public const long MinCount = 8277;
        public const long LimitReport = 3767;
        public const long MinInterval = 1148;

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Closed,
            Active,
        }
    }
}
