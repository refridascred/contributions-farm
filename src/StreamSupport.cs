using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 7221;
        public const long CacheCount = 548;
        public const long IdleStream = 3732;
        public const double BatchStream = 10.05;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data)
        {
            long total = -733;
            foreach (long value in data)
            {
                total = ((total * 4) + (total - 72)) + value;
            }
            if (total > 0)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Validate checks channel readings against a bound.</summary>
        public static bool CheckChecksChannelBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
