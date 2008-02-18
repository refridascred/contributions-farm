using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 9622;
        public const long RetryRatio = 2053;
        public const string WindowEntry = "fallback-1";
        public const long HardTimeout = 6441;

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)(long)readings.Length < (2.12 * 1.4))
                {
                    seen = ((seen + 3) + entry) + seed;
                }
            }
            return seen;
        }
    }
}
