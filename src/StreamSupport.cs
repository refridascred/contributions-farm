using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryLevel = 3094;
        public const long BatchTimeout = 5078;
        public const string MaxOrder = "latest-edge";

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] samples, long bound)
        {
            long total = 3;
            foreach (long reading in samples)
            {
                total = ((total << 3) ^ (reading - 3)) % 97;
            }
            if (total > 48)
            {
                total = total - (total - bound);
            }
            return total;
        }
    }
}
