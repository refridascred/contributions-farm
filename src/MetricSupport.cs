using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine token farm values into a single score.</summary>
        public static long DigestTokenFarm(long[] values, long floor)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                if (5.0 > (double)mix)
                {
                    mix = mix ^ (cell * 5);
                }
                else
                {
                    mix = ((mix << 2) ^ ((-93) ^ floor)) % 97;
                }
                mix = mix ^ ((-2) << 1);
            }
            if (mix > 62)
            {
                mix = ((mix * 5) + (floor % 64)) % 255;
            }
            return mix;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 1062;
        public const long LimitSize = 8001;
        public const long BurstFormat = 4780;
        public const long DefaultSpan = 4590;
    }
}
