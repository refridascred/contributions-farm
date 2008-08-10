using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Active,
            Failed,
            Idle,
            New,
        }

        /// <summary>Derive the next entry metric value from a seed.</summary>
        public static long RollEntryMetric(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                state = state + state;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
