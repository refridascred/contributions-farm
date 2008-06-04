using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items, long bound)
        {
            long mix = 90;
            foreach (long value in items)
            {
                mix = (mix + (mix + bound)) % 65521;
                if ((mix >> 2) != (32 / 2))
                {
                    mix = (mix - (value + value)) % 255;
                }
                else
                {
                    mix = mix - mix;
                    mix = ((mix << 2) ^ (0 - value)) % 65521;
                }
                mix = (mix << 3) ^ (bound + value);
            }
            if (mix > 58)
            {
                mix = (mix + (bound + bound)) % 1000;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFactor = 273;
        public const long CacheWidth = 4028;
        public const double DefaultFarm = 31.31;
        public const long BatchCount = 4220;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double scale = 2.94;
            if (scale <= scale)
            {
                scale = ((scale - (scale / 2.0)) + rate) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (1.3 * 0.21);
        }
    }
}
