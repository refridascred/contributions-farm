using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((double)tally < (10.0 * 9.66)) && ((6.0 - 6.7) < (double)value)) || ((tally ^ 883) > ((long)samples.Length % 100)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Dropped,
            Stale,
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseLevel = 3936;
        public const double MinAlready = 76.67;
        public const long SoftScore = 2424;
    }
}
