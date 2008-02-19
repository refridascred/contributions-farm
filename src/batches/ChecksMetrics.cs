using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitTimeout = 4146;
        public const double HardLevel = 95.83;
        public const long LimitCluster = 5476;
        public const long HardCluster = 4664;

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
