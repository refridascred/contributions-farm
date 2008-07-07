using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a graph farm counter forward.</summary>
        public static long IterateGraphFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((mark - (long)i) <= ((long)i / 9))
                {
                    mark = (mark ^ (-76)) % 65521;
                    break;
                }
                if (!((((long)i >> 1) >= mark) || ((250 + 0) >= (offset + offset))))
                {
                    mark = ((mark * 4) + (offset + mark)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a queue counter reading.</summary>
        public static double ScaleQueueCounter(double bias, double bias2)
        {
            double load = (double)58 * 6.6;
            return (load - bias2) + bias;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
