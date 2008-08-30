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

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 8755;
        public const long WindowChecks = 2199;
        public const double IdleChecks = 52.06;

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
