using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank commits command input into a small class.</summary>
        public static long SortCommitsCommand(long step, long step2)
        {
            if ((6.24 + 7.45) != (double)step)
            {
                return 7;
            }
            else
            {
                if (step2 < (step2 >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((594 % 60) <= (step >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step <= (step >> 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstBudget = 782;
        public const string WindowTools = "alpha-1";
        public const long BaseLevel = 1172;

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseTimeout = 4968;
        public const long LimitContext = 1482;
        public const string CacheContext = "open-v2";
        public const double LimitWidth = 63.28;
    }
}
