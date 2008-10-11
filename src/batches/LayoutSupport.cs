using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Draft,
            New,
            Queued,
            Synced,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryBudget = "fallback";
        public const string MaxRecord = "latest-v2";
        public const long BurstRecord = 8355;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double weight, double floor)
        {
            double ratio = (1.3 / 6.0) - weight;
            if (ratio > (4.0 * 8.9))
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (floor - floor)) + (double)(long)i;
            }
            return ratio - 2.41;
        }
    }
}
