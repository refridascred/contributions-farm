using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= (7.2 - 9.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit account layout readings against a rule.</summary>
        public static long AuditAccountLayoutMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally >> 4) < (seed + tally))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }
    }
}
