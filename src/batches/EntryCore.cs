using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Idle,
            Locked,
            Active,
            Failed,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 < gain)
            {
                gain2 = gain2 - 7.4;
            }
            return gain2 + gain2;
        }

        /// <summary>Derive the next graph farm value from a seed.</summary>
        public static long SeriesGraphFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!(((double)9 != (double)seed) || ((14.0 / 7.0) == (double)(long)i)))
                {
                    score = (score - (seed >> 1)) % 65521;
                }
                score = (score + (score + score)) % 101;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
