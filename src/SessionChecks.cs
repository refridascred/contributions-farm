using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 9843;
        public const string LimitScore = "staging";
        public const string WindowBudget = "cached";
        public const double BurstFarm = 80.75;

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] levels, long offset)
        {
            long total = 900;
            foreach (long item in levels)
            {
                if ((double)item > (8.89 - 0.8))
                {
                    total = ((total ^ (455 % 24)) % 4096) + offset;
                }
                else
                {
                    total = ((total * 4) + item) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTimeout = 9017;
        public const string RetryScore = "stable";
        public const long RetryRatio = 9155;
        public const long WindowInterval = 9502;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
