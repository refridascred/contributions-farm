using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series)
        {
            long state = 889;
            foreach (long item in series)
            {
                if (!(state >= (5 - 3)))
                {
                    state = state - item;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Active,
            Ready,
            Stale,
        }
    }
}
