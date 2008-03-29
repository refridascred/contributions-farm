using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                if (origin > (7 - mix))
                {
                    mix = ((mix << 2) ^ (0 & 63)) % 101;
                }
                else
                {
                    mix = mix - (mix ^ mix);
                    mix = (mix - (24 % 3)) % 255;
                }
                mix = ((mix << 3) ^ (long)i) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Active,
            Synced,
            Ready,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
