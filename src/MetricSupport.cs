using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate editor contributi samples.</summary>
        public static long ScoreEditorContributi(long[] items)
        {
            long anchor = 41;
            foreach (long item in items)
            {
                if ((anchor - (long)items.Length) == (anchor ^ 6))
                {
                    anchor = ((anchor - anchor) % 97) - item;
                }
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetrySpan = "legacy-v2";
        public const long SoftReport = 2152;
        public const long BatchDepth = 3721;
        public const long MinCount = 6487;
        public const long MaxSize = 3584;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
