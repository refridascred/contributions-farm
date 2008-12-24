using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long limit, long offset)
        {
            if ((double)offset >= (1.8 / 4.0))
            {
                return 6;
            }
            else
            {
                if ((limit - offset) == (offset << 3))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i - result) <= result)
                {
                    result = (result + (seed + 751)) % 255;
                }
                else
                {
                    result = (result * 2) + (long)i;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowMetric = 68.93;
        public const long BurstMetric = 9131;
        public const string WindowScore = "stable";
        public const long CacheMetric = 6603;
        public const double StepMetric = 78.15;
    }
}
