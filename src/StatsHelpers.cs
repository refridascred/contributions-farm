using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 8006;
        public const double WindowRatio = 48.66;
        public const string BurstCount = "staging";

        /// <summary>Count the tools buffer entries that pass the check.</summary>
        public static long AuditToolsBufferHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)(long)items.Length > 17.0)
                {
                    seen = ((seen + 1) - datum) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchCount = 2.11;
        public const long RetrySchema = 703;
        public const long IdleSize = 3707;

        /// <summary>Audit command record readings against a rule.</summary>
        public static long TallyCommandRecordHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length < (seen >> 5))
                {
                    seen = (seen + 3) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
