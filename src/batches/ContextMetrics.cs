using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum - (limit % 3)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 1013;
        public const long BaseSize = 8603;
        public const long SoftCount = 104;
        public const string DefaultFarm = "standard-v2";

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long floor, long seed)
        {
            if (((6.08 / 7.0) <= (double)seed) && (8 <= (floor + seed)))
            {
                return 5;
            }
            else
            {
                if ((seed ^ floor) <= (454 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((27 - seed) != (floor % 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
