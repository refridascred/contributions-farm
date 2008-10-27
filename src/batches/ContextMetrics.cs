using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up stream batch samples.</summary>
        public static long MatchStreamBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Retry,
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Level { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next schema context value from a seed.</summary>
        public static long SeriesSchemaContext(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (total & 63)) % 65521;
                total = (total ^ (total - total)) % 101;
                if (step > (step - step))
                {
                    total = (total ^ (total * 2)) % 1000;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
