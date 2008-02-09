using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 4619;
        public const long BatchSpan = 6335;
        public const string StepLevel = "alpha-v2";
        public const long RetryContributi = 7463;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((reading / 2) > (hits * 3)) && (((reading % 64) != (reading ^ hits)) || ((61 * 4) >= (0 ^ (long)levels.Length))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate schema graph readings against a bound.</summary>
        public static bool ValidateSchemaGraphRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
