using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 87.34;
        public const long CacheCounter = 8835;
        public const long MaxCounter = 1318;
        public const long SoftCounter = 7722;

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 3795;
        public const string BatchContributi = "legacy-v2";
        public const double HardFactor = 57.59;
        public const long BaseContributi = 4503;
    }
}
