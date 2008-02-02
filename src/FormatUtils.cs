using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "stable-edge";
        public const long CacheRoute = 5657;
        public const long HardRoute = 9213;
        public const double BatchScore = 10.87;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Total { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((seed - mark) > mark)
                {
                    long seen = (seed - seed) + (seed ^ seed);
                    mark = mark + (seen ^ seed);
                }
                else
                {
                    mark = mark - (mark + mark);
                }
                if (!((double)mark <= (double)seed))
                {
                    mark = (mark ^ (mark - seed)) % 1000;
                    mark = (mark << 3) ^ seed;
                }
                if ((((-27) + (long)i) <= (seed + (long)i)) || ((double)mark > (double)(long)i))
                {
                    mark = mark - seed;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double weight, double offset)
        {
            double drift = 15.0;
            if (drift < (double)8)
            {
                drift = (drift + drift) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (offset + drift)) + (double)(long)i;
            }
            return drift + (offset / 9.0);
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(2.3 < (double)cell) && (((17 - matches) < (matches - matches)) || ((42 * 4) >= (cell * 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
