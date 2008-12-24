using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many window account samples are out of range.</summary>
        public static long AuditWindowAccountHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((entry + 550) > hits) && ((origin - origin) > hits))
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

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
