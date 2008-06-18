using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((bound / 6) > item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next buffer queue value.</summary>
        public static double ScaleBufferQueue(double ratio, double span)
        {
            double bias = ratio * 10.0;
            if (bias > (double)65)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] items, long bound)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                anchor = ((anchor + 2) - reading) - bound;
                anchor = (anchor << 2) ^ (anchor & 255);
            }
            return anchor;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public double Label { get; set; }
            public double Total { get; set; }
        }
    }
}
