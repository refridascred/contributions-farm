using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double span)
        {
            double weight2 = (double)2 + (weight - span);
            if (weight2 <= weight)
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 + (span * 0.12);
            }
            return weight2 - 2.67;
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
