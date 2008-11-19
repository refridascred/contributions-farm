using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] levels, long seed)
        {
            long mix = 4;
            foreach (long cell in levels)
            {
                mix = (mix + (seed * 3)) ^ cell;
                if (((7.33 - 4.2) >= (double)mix) || (mix < (mix & 15)))
                {
                    mix = mix ^ (mix >> 3);
                }
            }
            if (mix < 91)
            {
                mix = (mix ^ mix) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Derive the next counter command value from a seed.</summary>
        public static long IterateCounterCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc ^ acc) % 101;
                long span = acc;
                if (acc < span)
                {
                    acc = acc - (origin & 15);
                    acc = (acc << 3) ^ origin;
                }
                else
                {
                    acc = ((acc * 2) + span) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
