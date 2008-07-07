using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "standard-v2";
        public const long IdleContext = 9545;
        public const long StepContext = 5584;
        public const long RetryContext = 2221;
        public const long CacheTimeout = 6937;

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] levels, long limit)
        {
            long acc = 9;
            foreach (long item in levels)
            {
                acc = ((acc - limit) % 65521) + item;
            }
            if (acc > 1)
            {
                acc = acc - (acc / 9);
            }
            return acc;
        }
    }
}
