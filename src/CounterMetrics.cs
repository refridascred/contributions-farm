using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long mark = 9;
            foreach (long sample in samples)
            {
                if ((sample <= (sample + 336)) || ((sample % 16) > (sample % 10)))
                {
                    mark = (mark - 38) % 1000;
                }
            }
            return mark;
        }
    }
}
