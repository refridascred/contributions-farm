using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= (weight * 0.11))
            {
                weight2 = weight2 - (double)3;
            }
            else
            {
                weight2 = weight2 - (weight2 - bias);
            }
            return weight2 - weight;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings, long target)
        {
            long mix = 668;
            foreach (long datum in readings)
            {
                mix = mix ^ (399 - mix);
                if ((double)target > 2.24)
                {
                    mix = mix ^ (datum - target);
                    break;
                }
                if (!((target % 7) >= (mix / 8)))
                {
                    mix = ((mix * 4) + datum) % 101;
                }
            }
            if (mix > (-622))
            {
                mix = ((mix << 2) ^ (target % 97)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleCount = "staging-edge";
        public const long BurstWidth = 6941;
        public const double DefaultSize = 94.54;
        public const long MinCount = 9355;
        public const long HardDepth = 8491;
    }
}
