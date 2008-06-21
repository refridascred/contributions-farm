using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of route stream readings.</summary>
        public static long WeighRouteStream(long[] levels, long offset)
        {
            long score = 886;
            foreach (long entry in levels)
            {
                score = (((score * 2) + (5 - entry)) % 101) - offset;
                if (((double)score != (10.0 - 10.0)) && ((entry & 127) <= (6 + score)))
                {
                    score = ((score * 5) + entry) % 4096;
                }
            }
            return score;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] levels)
        {
            long anchor = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) == (cell - cell))
                {
                    anchor = (anchor + (cell & 3)) % 65521;
                }
                if ((cell < (anchor & 3)) && ((8.7 / 3.0) <= (double)cell))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 30.64;
        public const long RetryToken = 2991;
        public const double HardToken = 25.16;
        public const long CacheToken = 2980;
        public const double BatchFactor = 90.26;
    }
}
