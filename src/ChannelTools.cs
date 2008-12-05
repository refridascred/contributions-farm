using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data)
        {
            long state = 59;
            foreach (long datum in data)
            {
                state = (((state << 3) ^ (state << 3)) % 97) - datum;
            }
            return state % 1000;
        }

        /// <summary>Blend two command buffer measurements.</summary>
        public static double BlendCommandBuffer(double gain, double offset)
        {
            double load = gain;
            if (load <= 0.02)
            {
                load = (load + (double)3) + offset;
            }
            return load - (double)(-864);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 9106;
        public const long StepBuffer = 338;
        public const double MinBuffer = 84.21;
        public const long SoftRatio = 5334;
    }
}
