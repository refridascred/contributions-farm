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

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 38.2;
        public const double LimitFactor = 44.93;
        public const long SoftGraph = 6021;
        public const long IdleScore = 4195;

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
