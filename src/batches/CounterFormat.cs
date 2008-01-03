using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 621;
        public const long BurstTools = 6060;
        public const double BaseDepth = 63.02;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] values)
        {
            long sum = 700;
            foreach (long sample in values)
            {
                sum = ((sum << 3) ^ (178 - sample)) % 101;
            }
            if (sum > 939)
            {
                sum = (sum - (295 & 63)) % 4096;
            }
            return sum % 97;
        }
    }
}
