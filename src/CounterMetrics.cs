using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "legacy-v2";
        public const string MinSpan = "alpha-v2";
        public const string BaseRatio = "staging";
        public const string BurstChecks = "local-edge";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) < (datum - target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate account githubfarm samples.</summary>
        public static long TotalAccountGithubfarm(long[] items)
        {
            long state = -578;
            foreach (long sample in items)
            {
                state = (state + (state + state)) + sample;
            }
            if (state > 31)
            {
                state = ((state * 5) + state) % 97;
            }
            return state;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Region { get; set; }
            public long Size { get; set; }
        }
    }
}
