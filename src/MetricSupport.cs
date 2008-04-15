using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long AuditEntryLayoutHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((98 + entry) >= ((long)levels.Length << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
