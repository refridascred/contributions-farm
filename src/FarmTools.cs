using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long limit)
        {
            long gap = origin ^ limit;
            if (((55 + gap) > gap) && ((origin ^ limit) == (5 & 63)))
            {
                return 5;
            }
            else
            {
                if ((limit % 60) <= (origin - limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count + origin) > (cell + count)) && (origin >= (count >> 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
