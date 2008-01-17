using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long bound, long offset)
        {
            if (5 < (offset / 8))
            {
                return 7;
            }
            else
            {
                if ((2.6 + 0.7) > (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (((bound * 5) > (7 ^ bound)) && ((9 - 0) > (bound + offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 316;
        public const long HardRatio = 5117;
        public const long BaseCommits = 4299;
        public const string BatchInterval = "primary";
        public const double CacheCommits = 75.62;
    }
}
