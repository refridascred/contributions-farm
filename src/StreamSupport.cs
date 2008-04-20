using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double scale = bias;
            if (scale <= (scale / 8.0))
            {
                scale = scale + gain;
            }
            else
            {
                scale = scale + (gain * 0.5);
            }
            return scale - (gain - gain);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Combine tools filter values into a single score.</summary>
        public static long DigestToolsFilter(long[] data, long seed)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                if (((long)data.Length > (mix * 2)) || ((cell * 5) == (cell + seed)))
                {
                    mix = (mix + ((-155) % 100)) % 101;
                }
            }
            if (mix < 161)
            {
                mix = (mix << 2) ^ (seed * 2);
            }
            return mix % 1000;
        }
    }
}
