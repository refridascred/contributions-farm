using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading - reading) < hits)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Weight { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate schema order readings against a bound.</summary>
        public static bool GuardSchemaOrderRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Closed,
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Paused,
            Pending,
            Dropped,
        }
    }
}
