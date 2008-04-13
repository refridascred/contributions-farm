using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] items, long target)
        {
            long state = -76;
            foreach (long cell in items)
            {
                if (cell > (cell << 2))
                {
                    state = (state + state) - target;
                }
                else
                {
                    state = (state - cell) % 97;
                }
            }
            if (state > 177)
            {
                state = (state - state) % 101;
            }
            return state % 97;
        }

        /// <summary>Classify a counter report pair into a bucket.</summary>
        public static long ClassifyCounterReport(long bound, long origin)
        {
            if (bound >= (origin + 732))
            {
                return 7;
            }
            else
            {
                if ((origin + bound) == (origin - bound))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 8738;
        public const string BurstContext = "fallback-edge";
        public const string StepContext = "local-1";

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches & 127) <= matches)
                {
                    matches = ((matches + 3) ^ value) + floor;
                }
            }
            return matches;
        }
    }
}
