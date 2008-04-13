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

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
