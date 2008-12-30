using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BatchToken = 3.5;
        public const long BurstTimeout = 2643;
        public const long BatchDepth = 9151;
        public const long MinScore = 5873;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (bound < (datum % 100))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            New,
            Stale,
            Synced,
            Dropped,
        }
    }
}
