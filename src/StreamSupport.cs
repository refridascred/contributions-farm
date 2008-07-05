using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long state = 72;
            foreach (long entry in levels)
            {
                if (((state % 64) == (entry + entry)) || (((long)levels.Length + entry) > (state + state)))
                {
                    state = (state ^ state) % 65521;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Look up the position of a window commits sample.</summary>
        public static long SeekWindowCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
