using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 5534;
        public const long IdleWidth = 8781;
        public const double IdleEditor = 23.66;
        public const double MinSpan = 35.82;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((3.39 - 0.6) > (double)matches))
                {
                    matches = ((matches + 1) ^ item) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Done,
            Closed,
        }
    }
}
