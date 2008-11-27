using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            Locked,
            Stale,
            New,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowInterval = 64.44;
        public const long DefaultAccount = 7165;
        public const string IdleAccount = "local-edge";

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count >> 2) < (count / 5)) || ((7.53 * 4.68) == (double)count))
                {
                    count = ((count + 2) - item) - floor;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 7971;
        public const long BurstRoute = 9317;
        public const double HardRoute = 24.48;
    }
}
