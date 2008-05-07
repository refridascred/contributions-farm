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

        /// <summary>Roll a already cluster counter forward.</summary>
        public static long SeriesAlreadyCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
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
