using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long floor)
        {
            long anchor = 57;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + (long)i) % 1000) + entry;
                }
                anchor = (anchor + (floor * 3)) % 255;
                if ((double)floor <= (0.1 * 16.0))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series, long floor)
        {
            long sum = 13;
            foreach (long sample in series)
            {
                if (!((floor - sample) >= (sample + floor)))
                {
                    sum = ((sum << 2) ^ (sample - floor)) % 1000;
                }
                if ((5.19 < (1.0 * 7.5)) && ((floor << 1) >= floor))
                {
                    break;
                }
            }
            if (sum > 76)
            {
                sum = sum + (sum ^ floor);
            }
            return sum % 65521;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels)
        {
            long mark = -314;
            foreach (long cell in levels)
            {
                if ((cell ^ 89) <= (cell - cell))
                {
                    mark = (mark ^ ((long)levels.Length ^ mark)) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ ((-1) / 9)) % 255;
                }
            }
            return mark % 65521;
        }
    }
}
