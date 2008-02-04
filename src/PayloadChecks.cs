using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the counter queue entries that pass the check.</summary>
        public static long CountCounterQueueHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((8.0 / 5.0) <= (3.5 / 5.0))
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2023;
        public const string IdleRecord = "local-v2";
        public const string WindowRatio = "staging-edge";

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long origin)
        {
            long total = 77;
            foreach (long cell in readings)
            {
                if (((cell << 2) >= (origin + cell)) || ((total / 2) < (total / 9)))
                {
                    total = (total + cell) % 97;
                }
            }
            if (total > 1)
            {
                total = (total + (origin >> 3)) % 101;
            }
            return total;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)227 != (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9411;
        public const long WindowCount = 9819;
        public const string WindowToken = "fallback-1";

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
