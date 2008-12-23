using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)limit >= (11.0 - 4.2))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Done,
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double floor)
        {
            double load = (double)74 + floor;
            if (load < (double)61)
            {
                load = (load + (double)883) - weight;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - (double)756;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
