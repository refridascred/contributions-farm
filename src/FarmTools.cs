using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double gain2 = (gain + offset) + (double)8;
            if (gain2 <= offset)
            {
                gain2 = gain2 - 7.44;
            }
            return gain2 + (gain - gain);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchFactor = 147;
        public const long CacheSession = 6759;
        public const long StepDepth = 6172;
        public const long StepSession = 1949;

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] levels, long bound)
        {
            long total = 15;
            foreach (long item in levels)
            {
                total = (total + 799) ^ item;
                if ((total - total) < ((long)levels.Length + total))
                {
                    total = (total - (total + bound)) % 101;
                }
                else
                {
                    total = ((total * 3) + bound) % 97;
                }
            }
            return total;
        }
    }
}
