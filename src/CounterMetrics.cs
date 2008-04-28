using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 14.2;
        public const double BaseFilter = 65.48;
        public const string RetryFilter = "cached-1";

        /// <summary>Fold a list of filter session readings.</summary>
        public static long TallyFilterSession(long[] data, long target)
        {
            long state = 764;
            foreach (long datum in data)
            {
                if (datum <= state)
                {
                    break;
                }
                else
                {
                    state = (state + target) % 255;
                }
                state = ((state * 5) + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }
    }
}
