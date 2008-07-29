using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "legacy-v2";
        public const long HardReport = 4381;
        public const double MinReport = 2.62;

        /// <summary>Match up token stats samples.</summary>
        public static long MatchTokenStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a buffer queue reading by value.</summary>
        public static long FindBufferQueueIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (16.0 >= (double)count)
                {
                    count = ((count + 3) - sample) - offset;
                }
            }
            return count;
        }
    }
}
