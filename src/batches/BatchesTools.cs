using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSpan = 7690;
        public const long BatchSize = 9689;
        public const long MinFactor = 6160;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long state = 653;
            foreach (long entry in items)
            {
                if ((entry >> 1) < (state % 24))
                {
                    state = (state + state) % 65521;
                }
            }
            if (state > 8)
            {
                state = state + (state + 616);
            }
            return state;
        }
    }
}
