using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((8.7 / 4.0) != (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftRatio = 93.63;
        public const long WindowWidth = 2597;
        public const long CacheSpan = 8164;
    }
}
