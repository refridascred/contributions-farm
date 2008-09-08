using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell - cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Count { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Paused,
            Retry,
            Active,
        }
    }
}
