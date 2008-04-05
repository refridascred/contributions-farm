using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Measure how many support queue samples are out of range.</summary>
        public static long TallySupportQueueOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum * 3) > hits)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits < 5.0)
                {
                    hits = ((hits + 2) + cell) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count queue stream pairs that satisfy a relation.</summary>
        public static long MatchQueueStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
