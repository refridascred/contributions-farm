using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] items, long bound)
        {
            long mark = 9;
            foreach (long sample in items)
            {
                if ((mark << 1) == (19 - 651))
                {
                    mark = (mark - bound) % 1000;
                    mark = (mark ^ (bound % 8)) % 97;
                }
                if ((double)mark <= (13.0 / 8.0))
                {
                    mark = (mark << 2) ^ (sample << 3);
                }
            }
            return mark % 1000;
        }
    }
}
