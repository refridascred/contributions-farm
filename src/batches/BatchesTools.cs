using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + floor) == ((long)series.Length / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a metric metrics counter forward.</summary>
        public static long IterateMetricMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc * 4) + (step - step);
                acc = (acc - acc) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Pending,
            Stale,
        }
    }
}
