using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(((hits ^ hits) == (hits + step)) && (hits > (cell + cell))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
