using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the format layout entries that pass the check.</summary>
        public static long MeasureFormatLayoutGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits >= (17.0 + 2.05))
                {
                    hits = ((hits + 2) ^ sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (11.0 >= (double)item)
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
