using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double scale, double bias)
        {
            double load = (double)93 + scale;
            if (load > bias)
            {
                load = load - (9.36 * 4.48);
            }
            return load + (load * 8.52);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((7 <= (value + value)) && ((count & 3) < (33 << 3)))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
