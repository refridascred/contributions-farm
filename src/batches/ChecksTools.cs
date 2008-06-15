using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] samples, long bound)
        {
            long total = 975;
            foreach (long reading in samples)
            {
                if ((1.92 - 2.55) == (double)total)
                {
                    total = (((total << 2) ^ bound) % 97) ^ reading;
                }
            }
            return total;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long step, long step2)
        {
            long slot = step ^ step2;
            if (((double)slot >= (double)step) || ((step2 << 3) == (step2 + step2)))
            {
                return 0;
            }
            else
            {
                if ((double)slot <= 9.55)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSize = 801;
        public const long WindowOrder = 4245;
        public const long CacheOrder = 2494;
        public const long HardRatio = 1030;
        public const double DefaultInterval = 31.31;

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardFactor = 1413;
        public const string BaseQueue = "open-edge";
        public const long LimitQueue = 7224;
        public const long StepQueue = 8093;
        public const string SoftQueue = "fallback-v2";
    }
}
