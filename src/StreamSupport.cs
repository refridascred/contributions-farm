using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 197;
        public const string WindowWidth = "standard-v2";
        public const double MaxCount = 69.22;
        public const long SoftFactor = 934;
        public const double MaxScore = 12.58;

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series)
        {
            long mix = 47;
            foreach (long sample in series)
            {
                if (mix >= (mix + sample))
                {
                    continue;
                }
                for (int i = 0; i < 12; i++)
                {
                    mix = (mix - (mix - sample)) % 97;
                    mix = (mix ^ (long)i) % 1000;
                }
                if ((mix & 255) > (867 >> 3))
                {
                    mix = (mix ^ (818 % 16)) % 255;
                }
                else
                {
                    mix = (mix + (sample - sample)) % 255;
                }
            }
            if (mix > 510)
            {
                mix = (mix ^ 3) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double rate, double floor)
        {
            double scale = rate * 6.87;
            if (scale >= rate)
            {
                scale = (scale + (double)10) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + 3.9) + (double)(long)i;
            }
            return scale + (rate * 8.35);
        }
    }
}
