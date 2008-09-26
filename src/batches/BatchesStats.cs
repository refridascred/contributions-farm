using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 5537;
        public const long MinAccount = 2142;
        public const long BurstAccount = 5478;
        public const string CacheAccount = "local-v2";
        public const long LimitScore = 7639;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long bound, long origin)
        {
            if ((double)bound != (7.7 / 5.0))
            {
                return 7;
            }
            else
            {
                if ((9.0 * 0.02) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (origin > (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin ^ 876) >= (origin % 12))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double bias, double span)
        {
            double gain = (double)(425 - (-379));
            if (gain <= (double)878)
            {
                gain = (gain + bias) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 13.0) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 5090;
        public const long StepBudget = 2267;
        public const long SoftFactor = 6555;
        public const long LimitCommits = 2336;
        public const long HardBudget = 4826;
    }
}
