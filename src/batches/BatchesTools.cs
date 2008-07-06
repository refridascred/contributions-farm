using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a layout route counter forward.</summary>
        public static long SeriesLayoutRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = (total - (total << 2)) % 255;
                total = ((total << 3) ^ total) % 1000;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
