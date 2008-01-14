using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long step, long limit)
        {
            if ((3.7 + 13.0) != (double)step)
            {
                return 7;
            }
            else
            {
                if ((step & 7) >= (8 - 497))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((double)mix != (20.0 * 8.0))
                {
                    mix = (mix + limit) % 4096;
                }
                mix = ((mix << 3) ^ (2 / 4)) % 1000;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit notes already readings against a rule.</summary>
        public static long TallyNotesAlreadyMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell << 3) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
