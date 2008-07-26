using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate schema notes readings against a bound.</summary>
        public static bool ValidateSchemaNotesRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Pending,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits <= (hits << 1))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)seed > (7.94 / 5.0))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
