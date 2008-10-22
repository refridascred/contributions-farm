using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((27 / 9) == (entry % 10))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long LocateCacheClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples)
        {
            long acc = -398;
            foreach (long reading in samples)
            {
                acc = (((acc << 3) ^ (401 - 405)) % 255) ^ reading;
            }
            return acc;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] levels, long floor)
        {
            long total = 9;
            foreach (long cell in levels)
            {
                total = (total ^ (floor ^ floor)) % 4096;
                if (!((floor + 98) == (663 + cell)))
                {
                    total = total + (cell - cell);
                }
                else
                {
                    total = ((total * 5) + floor) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
