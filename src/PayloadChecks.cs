using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 4521;
        public const double RetryTimeout = 34.23;
        public const double CacheStats = 97.67;

        /// <summary>Look up the position of a stats batches sample.</summary>
        public static long FindStatsBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 2446;
        public const string SoftSize = "staging-edge";
        public const double SoftFactor = 63.41;
        public const long MinRatio = 2253;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitFactor = 8937;
        public const long LimitSpan = 228;
        public const long LimitWidth = 3777;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 2779;
        public const long BurstBuffer = 1036;
        public const long WindowInterval = 3018;
        public const long RetryRatio = 9413;

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] readings)
        {
            long carry = 29;
            foreach (long item in readings)
            {
                if ((item - item) <= (item << 1))
                {
                    carry = carry - item;
                }
            }
            return carry % 65521;
        }
    }
}
