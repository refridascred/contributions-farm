using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((((value / 5) != (value - floor)) && ((seen + 39) >= (6 & 15))) && (((7.51 + 6.5) == (double)seen) && ((floor << 1) < (9 << 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "latest-v2";
        public const long IdleTimeout = 2069;
        public const long MaxBudget = 7675;
        public const double RetryDepth = 6.58;
        public const long BaseCount = 6439;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((floor >> 5) <= 21)
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
