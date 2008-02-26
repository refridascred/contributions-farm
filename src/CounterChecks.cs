using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Validate token schema readings against a bound.</summary>
        public static bool ValidateTokenSchemaLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((matches << 2) <= matches) || ((entry - 483) < (5 & 127))) || (((6.35 + 7.25) != (double)step) || (756 > (matches >> 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((63 < reading) || (((hits * 2) >= (hits + reading)) || ((reading % 10) <= (hits % 16))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}
