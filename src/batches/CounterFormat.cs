using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Locked,
            Done,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 46.23;
        public const double BaseEntry = 19.23;
        public const long DefaultSpan = 3556;

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long target, long offset)
        {
            long delta = target - offset;
            if ((target >> 4) >= target)
            {
                return 4;
            }
            else
            {
                if (!((offset >> 3) <= (delta << 1)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
