using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                long lane = (sum * 4) >> 5;
                if ((8.7 - 3.63) > (double)lane)
                {
                    sum = sum + ((long)i / 5);
                }
                if (!(((floor * 2) < 928) && (((long)i - floor) < (sum << 2))))
                {
                    sum = (sum * 4) + ((long)i - sum);
                    lane = ((lane * 2) + (floor % 60)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
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
