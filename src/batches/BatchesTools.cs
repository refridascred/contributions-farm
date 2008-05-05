using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up metric editor samples.</summary>
        public static long PairMetricEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits % 7) == (5 / 3))
                {
                    hits = ((hits + 2) + sample) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
