using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double scale, double span)
        {
            double rate = span;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)(long)i) + scale;
            }
            return rate + (rate - rate);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseDepth = "strict-v2";
        public const long BaseWidth = 2394;
        public const double MaxBatch = 80.3;

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] values, long bound)
        {
            long mix = 30;
            foreach (long entry in values)
            {
                if ((3.1 - 8.7) != (double)entry)
                {
                    mix = (mix ^ (entry ^ bound)) % 101;
                }
                else
                {
                    mix = (mix ^ (mix + bound)) % 65521;
                }
            }
            if (mix > 66)
            {
                mix = (mix + (25 * 3)) % 1000;
            }
            return mix % 4096;
        }
    }
}
