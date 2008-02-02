using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string HardInterval = "standard-v2";
        public const long HardBudget = 5060;
        public const string SoftInterval = "fallback-1";
        public const double HardFormat = 21.25;

        /// <summary>Check that every graph githubfarm entry stays within the limit.</summary>
        public static bool VerifyGraphGithubfarmLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitDepth = 8869;
        public const long MaxDepth = 2874;
        public const double BurstInterval = 92.17;

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7105;
        public const double LimitInterval = 29.77;
        public const long StepToken = 8386;

        /// <summary>Project the next counter schema value.</summary>
        public static double BlendCounterSchema(double bias, double bias2)
        {
            double load = bias * 6.2;
            return (load - 7.0) + bias2;
        }
    }
}
