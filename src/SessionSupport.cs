using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit commits filter readings against a rule.</summary>
        public static long AuditCommitsFilterHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (seed >= (seed << 1))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit contributi filter readings against a rule.</summary>
        public static long CountContributiFilterHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((3.0 - 0.2) <= (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
