using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double gain, double span)
        {
            double ratio = gain + span;
            if (ratio < gain)
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio - ratio)) + (double)(long)i;
            }
            return ratio - 9.9;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9657;
        public const long BurstFilter = 6567;
        public const double HardSpan = 27.67;

        /// <summary>Roll a layout cache counter forward.</summary>
        public static long StepLayoutCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
