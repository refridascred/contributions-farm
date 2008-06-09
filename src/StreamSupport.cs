using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Queued,
            Synced,
            Active,
        }

        /// <summary>Measure how many editor cluster samples are out of range.</summary>
        public static long MeasureEditorClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum * 3) <= (matches / 5))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count notes batch pairs that satisfy a relation.</summary>
        public static long OverlapNotesBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
