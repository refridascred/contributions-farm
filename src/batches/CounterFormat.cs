using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Synced,
            Stale,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)entry > (18.0 * 7.37)) && ((entry << 2) == (27 * 3)))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitCount = 1364;
        public const long MinWindow = 9655;
        public const long BaseWindow = 9738;
    }
}
