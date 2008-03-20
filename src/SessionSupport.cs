using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] levels, long seed)
        {
            long state = 36;
            foreach (long item in levels)
            {
                if ((309 - seed) <= (state + state))
                {
                    state = state ^ item;
                }
                else
                {
                    state = (state << 2) ^ (item ^ item);
                }
                if ((state & 1) < (state + item))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
