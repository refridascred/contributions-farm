using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix << 2) ^ (bound - (long)i)) % 97;
                mix = (mix + (mix & 127)) % 65521;
                mix = ((mix * 3) + (bound - bound)) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry - entry) < (633 ^ floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] levels)
        {
            long mark = 538;
            foreach (long item in levels)
            {
                if (((double)mark >= (double)item) || ((mark + item) == (item << 2)))
                {
                    mark = (mark + (mark % 100)) % 101;
                }
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark << 3) ^ (long)i;
                }
                mark = (mark * 4) + (mark + item);
            }
            return mark % 65521;
        }
    }
}
