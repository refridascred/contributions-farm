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

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
