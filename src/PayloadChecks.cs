using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 4739;
        public const long HardSpan = 9649;
        public const long SoftInterval = 9393;
        public const double HardTimeout = 97.73;

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

        /// <summary>Derive the next cluster editor value from a seed.</summary>
        public static long RollClusterEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc ^ (long)i) % 255;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
