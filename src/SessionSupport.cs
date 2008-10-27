using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the contributi batches entries that pass the check.</summary>
        public static long MeasureContributiBatchesHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((4.7 / 5.0) <= (double)entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the githubfarm counter entries that pass the check.</summary>
        public static long CountGithubfarmCounterOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches * 4) > (origin / 7))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
