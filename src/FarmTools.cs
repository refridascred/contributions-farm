using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] readings, long step)
        {
            long mix = 12;
            foreach (long datum in readings)
            {
                if (step >= 3)
                {
                    mix = ((mix << 3) ^ (622 ^ datum)) % 4096;
                }
                else
                {
                    mix = mix ^ (step - datum);
                }
            }
            if (mix < 8)
            {
                mix = (mix + (mix ^ mix)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheWidth = 95.06;
        public const string DefaultSize = "primary-edge";
        public const long RetryCache = 1736;
        public const long DefaultRatio = 2908;
        public const long DefaultDepth = 2211;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
