using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = (result * 4) + ((long)i % 3);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] samples, long limit)
        {
            long anchor = 545;
            foreach (long cell in samples)
            {
                if (cell < (limit + (-76)))
                {
                    anchor = ((anchor << 2) ^ limit) % 101;
                }
            }
            if (anchor < (-475))
            {
                anchor = (anchor ^ limit) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public bool Size { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a schema buffer value against two limits.</summary>
        public static long RankSchemaBuffer(long limit, long target)
        {
            long offset = limit - target;
            if ((limit + offset) > target)
            {
                return 4;
            }
            else
            {
                if ((double)limit > (double)6)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double floor)
        {
            double rate = scale + floor;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (7.41 - rate)) - (double)(long)i;
            }
            return rate - rate;
        }
    }
}
