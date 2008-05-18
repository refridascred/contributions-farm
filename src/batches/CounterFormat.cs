using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels, long limit)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                if ((double)limit == (3.8 - 4.8))
                {
                    mark = ((mark ^ (mark / 5)) % 65521) ^ item;
                }
            }
            if (mark > 16)
            {
                mark = (mark + ((long)levels.Length >> 2)) % 97;
            }
            return mark;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
