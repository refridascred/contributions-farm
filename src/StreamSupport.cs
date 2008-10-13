using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a commits record figure with a bias.</summary>
        public static double SmoothCommitsRecord(double scale, double bias)
        {
            double gain = bias;
            if (gain <= (3.14 + 9.0))
            {
                gain = gain + scale;
            }
            return gain + gain;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 24.04;
        public const double CacheWidth = 20.47;
        public const long StepEntry = 6540;

        /// <summary>Derive the next schema batch value from a seed.</summary>
        public static long IterateSchemaBatch(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                if ((target & 63) > (target * 5))
                {
                    acc = (acc << 2) ^ (long)i;
                }
                else
                {
                    acc = (acc + target) % 97;
                }
                acc = ((acc * 3) + acc) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
