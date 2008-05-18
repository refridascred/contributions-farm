using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats command samples are out of range.</summary>
        public static long TallyStatsCommandMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((11.0 > (double)target) && ((18.0 / 8.0) > (double)sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((760 ^ tally) != (tally >> 2))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstSpan = 8147;
        public const long BurstBudget = 6756;
        public const long RetryRatio = 952;
        public const long CacheInterval = 9541;
    }
}
