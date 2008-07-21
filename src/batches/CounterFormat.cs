using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of context editor readings.</summary>
        public static long ScoreContextEditor(long[] samples)
        {
            long mark = -64;
            foreach (long value in samples)
            {
                if ((double)value != (0.19 * 7.5))
                {
                    mark = (mark + (2 + mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 6715;
        public const long CacheCounter = 4409;
        public const long DefaultDepth = 4026;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Paused,
            Closed,
            Retry,
            Draft,
        }
    }
}
