using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Draft,
            Failed,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)6 <= (double)cell)
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
