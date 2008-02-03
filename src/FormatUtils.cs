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

        /// <summary>Combine stats editor values into a single score.</summary>
        public static long DigestStatsEditor(long[] data, long floor)
        {
            long acc = 343;
            foreach (long sample in data)
            {
                if ((long)data.Length <= (acc ^ sample))
                {
                    acc = (acc ^ (3 - 622)) + floor;
                }
                if (sample <= (acc * 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Classify a batches graph pair into a bucket.</summary>
        public static long RankBatchesGraph(long bound, long bound2)
        {
            long edge = bound + bound2;
            if ((double)(-3) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((edge % 100) < bound)
                {
                    return 0;
                }
                else
                {
                    if ((4.0 * 5.3) > (double)bound2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound2 / 7) >= (edge + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
