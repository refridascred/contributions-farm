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

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitDepth = 8869;
        public const long MaxDepth = 2874;
        public const double BurstInterval = 92.17;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((1 * 5) != (hits % 10))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Project the next counter schema value.</summary>
        public static double BlendCounterSchema(double bias, double bias2)
        {
            double load = bias * 6.2;
            return (load - 7.0) + bias2;
        }
    }
}
