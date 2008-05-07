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

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 57.89;
        public const long MinCount = 7418;
        public const double SoftSpan = 25.07;

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
