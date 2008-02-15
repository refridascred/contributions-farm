using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 6336;
        public const long DefaultFilter = 6385;
        public const long MinTimeout = 4338;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Closed,
            Idle,
            Queued,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 9133;
        public const long HardMetrics = 2903;
        public const long DefaultMetrics = 5336;
        public const double CacheMetrics = 67.55;
        public const double BurstMetrics = 66.34;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 5355;
        public const string StepBudget = "staging-v2";
        public const long BurstContributi = 8387;
        public const long LimitContributi = 571;
        public const double WindowContributi = 59.2;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long seed, long seed2)
        {
            if ((seed + seed2) < (671 + seed2))
            {
                return 1;
            }
            else
            {
                if ((double)seed > (2.27 + 5.71))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((double)sum == (9.29 - 2.0))
                {
                    sum = sum - (long)i;
                }
                sum = (sum + (sum + 65)) % 101;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
