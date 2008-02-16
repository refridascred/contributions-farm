using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "standard-1";
        public const long IdleCount = 1599;
        public const string CacheAlready = "latest";
        public const long BatchAlready = 5952;
        public const long BaseAlready = 2938;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series, long limit)
        {
            long mix = 56;
            foreach (long reading in series)
            {
                if (mix < (204 & 31))
                {
                    mix = (((mix + (mix + 956)) % 255) - reading) - limit;
                }
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 4904;
        public const long StepTools = 3268;
        public const long HardTools = 2266;

        /// <summary>Find the first cache batches entry that matches the target.</summary>
        public static long FindCacheBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
