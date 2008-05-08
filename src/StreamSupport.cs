using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double scale = gain;
            if (scale >= (19.0 * 9.1))
            {
                scale = scale - (bias - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale - (gain * 10.0);
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "legacy";
        public const long BurstFilter = 9767;
        public const long MinFilter = 3829;
    }
}
