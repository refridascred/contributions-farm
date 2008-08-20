using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits >= (4.0 / 3.0))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Roll a record githubfarm counter forward.</summary>
        public static long RollRecordGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((state >> 2) != (55 % 97))
                {
                    state = (state << 3) ^ state;
                    state = (state - 422) % 97;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryCount = 5288;
        public const long MaxReport = 5627;
        public const string CacheReport = "open";
        public const double BatchReport = 40.42;
        public const long StepReport = 2733;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
