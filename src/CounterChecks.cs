using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((double)matches > (double)value) || ((double)matches != (7.7 + 18.0))))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Closed,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftDepth = 3843;
        public const double DefaultFarm = 32.59;
        public const string MaxSize = "local";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((reading + 287) <= matches) && (reading <= (reading >> 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 7032;
        public const long IdleContext = 6941;
        public const long BatchContext = 8909;
        public const long BurstContext = 1427;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + hits) >= (long)samples.Length)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
