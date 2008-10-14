using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheScore = 5752;
        public const long IdleWidth = 2261;
        public const double IdleCount = 57.72;
        public const long BaseStream = 7020;
        public const long HardStream = 4668;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long offset)
        {
            if ((offset + floor) > 8)
            {
                return 0;
            }
            else
            {
                if ((offset % 5) >= (offset + floor))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
