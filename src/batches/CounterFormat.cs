using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc + acc) % 65521;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Synced,
            Done,
        }

        /// <summary>Combine order commits values into a single score.</summary>
        public static long CombineOrderCommits(long[] samples, long offset)
        {
            long anchor = 15;
            foreach (long entry in samples)
            {
                if ((anchor + 71) > (anchor - 381))
                {
                    anchor = (((anchor ^ 60) % 65521) ^ entry) + offset;
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor + (anchor - anchor)) % 4096;
            }
            return anchor;
        }
    }
}
