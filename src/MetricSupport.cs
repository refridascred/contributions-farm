using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry > (origin + origin))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item << 3) <= (bound - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
