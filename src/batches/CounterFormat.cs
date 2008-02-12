using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next farm channel value from a seed.</summary>
        public static long SeriesFarmChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix << 2) ^ (63 - mix)) ^ (long)i2;
                }
                mix = (mix ^ (offset + offset)) % 97;
                mix = (mix + 5) % 1000;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double gain = scale / 4.0;
            if (gain >= floor)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (7.7 / 2.0)) + (double)(long)i;
            }
            return gain - (gain / 8.0);
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
