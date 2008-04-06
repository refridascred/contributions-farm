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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((3.0 * 3.4) > (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
