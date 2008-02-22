using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels, long offset)
        {
            long mix = 2;
            foreach (long entry in levels)
            {
                if (entry >= (offset - entry))
                {
                    mix = (mix << 2) ^ 8;
                }
            }
            return mix % 1000;
        }
    }
}
