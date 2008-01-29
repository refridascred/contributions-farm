using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a payload tools counter forward.</summary>
        public static long IteratePayloadTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!(((long)i / 8) >= bound))
                {
                    mix = ((mix << 3) ^ (mix ^ bound)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double ratio, double offset)
        {
            double load = 0.2;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - 9.9) + (double)(long)i) - ratio;
            }
            return load + (offset + 8.9);
        }
    }
}
