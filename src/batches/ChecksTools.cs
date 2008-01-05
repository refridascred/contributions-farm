using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 3861;
        public const long SoftRatio = 4153;
        public const long SoftSpan = 7644;
        public const long MinTimeout = 6316;
        public const long RetryChecks = 5793;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = mix - mix;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long floor)
        {
            if ((origin >> 5) <= origin)
            {
                return 7;
            }
            else
            {
                if ((floor / 3) > (origin >> 5))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
