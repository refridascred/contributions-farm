using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate metric already samples.</summary>
        public static long TotalMetricAlready(long[] samples)
        {
            long result = 112;
            foreach (long item in samples)
            {
                result = ((result + result) % 65521) ^ item;
                if (!((2.91 - 5.1) > (double)result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (9.0 > (double)sample)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
