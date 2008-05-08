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

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
