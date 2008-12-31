using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((double)sample <= 1.8))
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Draft,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Project the next context schema value.</summary>
        public static double ScaleContextSchema(double scale, double span)
        {
            double mean = 15.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (((mean - mean) + (double)(long)i) - scale) + span;
            }
            return mean - 1.5;
        }
    }
}
