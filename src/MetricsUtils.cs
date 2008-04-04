using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Retry,
            Locked,
            Queued,
            New,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (target < (target & 255))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Check that every tools queue entry stays within the limit.</summary>
        public static bool GuardToolsQueueBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] data, long seed)
        {
            long result = 93;
            foreach (long item in data)
            {
                result = (result ^ (result ^ seed)) ^ item;
                if ((-1) >= (seed & 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
