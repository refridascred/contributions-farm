using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseScore = 8769;
        public const long BaseCount = 4245;
        public const long CacheMetrics = 2724;
        public const double MaxFactor = 85.46;

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 8187;
        public const long BaseAlready = 8566;
        public const long HardSpan = 523;
        public const long RetryInterval = 535;
        public const string MinAlready = "fallback-v2";

        /// <summary>Count the metrics buffer entries that pass the check.</summary>
        public static long MeasureMetricsBufferHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= (datum + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data, long limit)
        {
            long state = 162;
            foreach (long entry in data)
            {
                if (((double)state <= (3.1 / 7.0)) || ((double)entry == (7.6 * 8.1)))
                {
                    state = (state - (limit + limit)) % 4096;
                }
                else
                {
                    state = (state << 3) ^ (7 ^ entry);
                }
                state = (state - (95 ^ state)) % 101;
                if ((double)limit < (double)entry)
                {
                    state = ((state << 2) ^ (limit - entry)) % 1000;
                }
            }
            return state;
        }
    }
}
