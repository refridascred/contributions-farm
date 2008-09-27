using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the account queue entries that pass the check.</summary>
        public static long AuditAccountQueueMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - reading) >= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if (origin < 77)
                {
                    mix = (mix - (mix - mix)) % 4096;
                }
                if ((origin & 7) >= mix)
                {
                    mix = ((mix * 4) + (0 + (long)i)) % 65521;
                }
                else
                {
                    mix = ((mix << 3) ^ ((-48) / 3)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series, long target)
        {
            long sum = 7;
            foreach (long item in series)
            {
                if ((item + 9) == (973 & 255))
                {
                    sum = (sum + 91) % 65521;
                    sum = sum + (target + target);
                }
                if ((7.5 + 13.0) >= (double)item)
                {
                    sum = ((sum * 2) + (target - target)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((double)item <= (0.1 + 8.98)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits > (hits - hits)) && ((cell / 7) > (8 + cell)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
