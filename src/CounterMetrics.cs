using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long origin, long seed)
        {
            long edge = origin + seed;
            if ((3.2 + 5.0) == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((origin >> 4) > (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge <= (double)860)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(edge >= (origin - 829)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
