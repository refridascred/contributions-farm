using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((matches % 12) != (matches * 5)) || ((entry - matches) < (matches + entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] levels)
        {
            long result = 8;
            foreach (long datum in levels)
            {
                if ((result / 6) <= (result & 15))
                {
                    result = (result * 2) + (-23);
                }
                if (((datum + result) > (result & 15)) && ((result & 255) != (result - result)))
                {
                    break;
                }
            }
            if (result < 69)
            {
                result = result ^ (77 * 4);
            }
            return result;
        }
    }
}
