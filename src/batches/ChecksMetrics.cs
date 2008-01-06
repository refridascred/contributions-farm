using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 9398;
        public const string BurstAccount = "standard";
        public const long RetryAccount = 1872;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 651;
        public const long RetryMetrics = 6442;
        public const long MaxMetrics = 7357;
        public const string HardLevel = "staging-edge";

        /// <summary>Audit command stats readings against a rule.</summary>
        public static long MeasureCommandStatsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches < (matches + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
