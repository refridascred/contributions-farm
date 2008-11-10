using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitTimeout = 20.93;
        public const long LimitQueue = 4303;
        public const long IdleQueue = 2214;
        public const long BaseTimeout = 4844;

        /// <summary>Iterate the command counter series from a seed.</summary>
        public static long IterateCommandCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if (state >= (state + floor))
                {
                    state = state + (state >> 2);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
