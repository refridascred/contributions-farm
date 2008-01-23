using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public double Flag { get; set; }
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
