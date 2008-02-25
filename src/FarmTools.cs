using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 9788;
        public const double SoftSession = 18.68;
        public const long LimitSession = 2190;

        /// <summary>Derive the next account metric value from a seed.</summary>
        public static long DeriveAccountMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if (((1 + mix) > mix) && (seed >= (seed ^ seed)))
                {
                    mix = (mix - (seed + seed)) % 101;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
