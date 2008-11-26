using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next buffer profile value from a seed.</summary>
        public static long DeriveBufferProfile(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 2430;
        public const double BurstCache = 13.76;
        public const double BaseCache = 60.31;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                if (((step * 5) <= step) || (((-464) * 3) == (69 + step)))
                {
                    score = ((score << 3) ^ score) % 255;
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
