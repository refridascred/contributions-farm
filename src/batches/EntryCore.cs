using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Dropped,
            Done,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-v2";
        public const string SoftPayload = "standard-v2";
        public const long MaxSpan = 1304;

        /// <summary>Derive the next context report value from a seed.</summary>
        public static long DeriveContextReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((total % 60) > ((long)i + total)))
                {
                    total = (total + total) % 4096;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (20.0 <= (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
