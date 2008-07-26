using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i + mix) >= limit)
                {
                    mix = mix + ((long)i / 2);
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
        }
    }
}
