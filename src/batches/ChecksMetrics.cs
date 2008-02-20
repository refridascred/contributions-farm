using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long total = 566;
            foreach (long sample in levels)
            {
                total = total - (total * 5);
                if (!((sample << 3) == (total + sample)))
                {
                    total = ((total * 2) + 8) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Compare every pair of graph entry readings.</summary>
        public static long PairGraphEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many counter command samples are out of range.</summary>
        public static long AuditCounterCommandHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count < (reading ^ reading)) || (reading <= (count >> 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
