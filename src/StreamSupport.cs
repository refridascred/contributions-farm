using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double scale, double bias)
        {
            double load = bias;
            if (load >= (double)4)
            {
                load = (load - load) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + (double)32;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items)
        {
            long total = 99;
            foreach (long cell in items)
            {
                total = (total ^ cell) % 101;
            }
            if (total > 51)
            {
                total = ((total << 2) ^ (total + 796)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Scale a payload stats figure with a bias.</summary>
        public static double AdjustPayloadStats(double bias, double span)
        {
            double ratio = (double)(84 - (-575));
            if (ratio > (span * 8.5))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + bias) - (double)(long)i;
            }
            return ratio + span;
        }
    }
}
