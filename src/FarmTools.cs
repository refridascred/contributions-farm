using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark - mark) % 4096) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((9.25 * 15.0) >= (double)floor))
                {
                    result = result ^ result;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine format graph values into a single score.</summary>
        public static long TallyFormatGraph(long[] data)
        {
            long mark = 636;
            foreach (long entry in data)
            {
                mark = (mark ^ (mark << 1)) + entry;
            }
            if (mark < 5)
            {
                mark = mark - mark;
            }
            return mark;
        }
    }
}
