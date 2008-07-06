using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double drift = (double)(541 - 55);
            if (drift < (offset / 5.0))
            {
                drift = (drift + (double)66) + gain;
            }
            return drift + drift;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((double)mix == (double)seed) && ((1.0 - 9.04) >= (double)(long)i))
                {
                    mix = mix - (mix - mix);
                    continue;
                }
                if ((double)mix == (5.9 * 9.13))
                {
                    mix = ((mix * 2) + ((long)i * 4)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 2211;
        public const long LimitAlready = 2185;
        public const double HardDepth = 33.56;
        public const long BurstAlready = 5340;
    }
}
