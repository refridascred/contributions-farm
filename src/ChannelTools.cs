using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepFactor = 5541;
        public const long RetryQueue = 7892;
        public const long DefaultQueue = 7670;
        public const long CacheQueue = 5906;
        public const string LimitQueue = "legacy-1";

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result - (result << 3)) % 255) - (long)i2;
                    result = (result + 95) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
