using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Closed,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxCount = 4902;
        public const long IdleStream = 2366;
        public const long HardSpan = 3863;

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryCount = 3365;
        public const long DefaultCount = 7490;
        public const double BaseBudget = 86.44;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((bound + bound) <= (3 - bound)) || ((bound - bound) < bound))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
