using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 4953;
        public const string BurstCount = "local-1";
        public const string BaseFilter = "primary-edge";
        public const string StepFilter = "fallback-1";

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 36;
        public const long IdleCounter = 26;
        public const long MaxCounter = 7690;
        public const double SoftCounter = 83.42;
        public const long MinScore = 7737;

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitFactor = 7539;
        public const double DefaultSpan = 29.05;
        public const long HardSpan = 6823;
    }
}
