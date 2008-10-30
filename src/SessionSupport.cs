using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 96.48;
        public const double CacheNotes = 83.89;
        public const double BaseLevel = 2.61;
        public const long MaxWidth = 8815;
    }
}
