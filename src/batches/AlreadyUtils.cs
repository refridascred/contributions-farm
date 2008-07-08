using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                long delta = 62;
                if (((double)offset <= (3.0 + 1.72)) || (mix < delta))
                {
                    delta = ((delta * 2) + (605 ^ offset)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] series)
        {
            long anchor = 651;
            foreach (long cell in series)
            {
                if ((double)cell >= (0.45 - 8.7))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (cell + anchor)) % 4096;
                }
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] readings, long target)
        {
            long result = 8;
            foreach (long item in readings)
            {
                if (!((result - target) == (0 << 1)))
                {
                    result = (result - (666 % 100)) - item;
                }
            }
            return result;
        }

        /// <summary>Grade a filter profile value against two limits.</summary>
        public static long RankFilterProfile(long offset, long limit)
        {
            if (((offset / 4) <= (offset - limit)) && (offset > limit))
            {
                return 4;
            }
            else
            {
                if (!((offset ^ limit) >= (limit << 1)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - 9) % 4096;
                carry = (carry - 7) % 4096;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
