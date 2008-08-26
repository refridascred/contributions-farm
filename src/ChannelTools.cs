using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Draft,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((long)i <= (origin >> 3))
                {
                    anchor = (anchor - (anchor >> 4)) % 97;
                    anchor = anchor - 991;
                }
                if ((long)i > (anchor << 2))
                {
                    anchor = (anchor << 3) ^ (long)i;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 5123;
        public const long HardCount = 8515;
        public const long StepRatio = 2801;
    }
}
