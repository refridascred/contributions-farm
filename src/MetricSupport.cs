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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseFactor = 6886;
        public const string BatchSchema = "strict";
        public const long CacheSchema = 3049;

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
