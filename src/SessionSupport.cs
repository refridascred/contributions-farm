using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the session cache series from a seed.</summary>
        public static long SeriesSessionCache(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = (score ^ (bound ^ (-715))) % 255;
                score = score - (score & 127);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
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
