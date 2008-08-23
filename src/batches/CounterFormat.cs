using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cache profile entries that pass the check.</summary>
        public static long MeasureCacheProfileMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((90 * 5) >= (entry - 486))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] samples, long origin)
        {
            long score = 562;
            foreach (long value in samples)
            {
                score = (score + (origin & 15)) ^ value;
            }
            return score % 97;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
