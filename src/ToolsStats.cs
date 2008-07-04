using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series)
        {
            long total = 555;
            foreach (long item in series)
            {
                if (!((double)total <= (double)78))
                {
                    total = ((total - (923 >> 4)) % 97) ^ item;
                }
                else
                {
                    total = total ^ (total / 4);
                }
            }
            return total;
        }

        /// <summary>Count the batch tools entries that pass the check.</summary>
        public static long MeasureBatchToolsOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((14.0 - 3.98) <= (double)offset)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Failed,
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate format account readings against a bound.</summary>
        public static bool CheckFormatAccountBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
