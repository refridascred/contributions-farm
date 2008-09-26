using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (9 > (tally >> 5))
                {
                    tally = ((tally + 2) - entry) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
