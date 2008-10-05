using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of record format entries.</summary>
        public static long DigestRecordFormat(long[] items)
        {
            long state = 62;
            foreach (long sample in items)
            {
                state = ((state * 3) + (sample + sample)) % 1000;
                state = (state + (state * 3)) % 1000;
            }
            return state;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 9128;
        public const double LimitFactor = 43.0;
        public const long SoftRoute = 7177;
        public const long StepScore = 925;

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "latest-1";
        public const long BurstRecord = 8678;
        public const long MinRecord = 3528;
        public const long HardSize = 7582;
        public const long StepRecord = 5886;
    }
}
