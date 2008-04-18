using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryCount = 1089;
        public const long DefaultChannel = 4283;
        public const long LimitChannel = 3593;
        public const long CacheChannel = 1647;
        public const string BurstChannel = "alpha";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a payload contributi counter forward.</summary>
        public static long RollPayloadContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((mix - seed) > (seed ^ seed))
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
