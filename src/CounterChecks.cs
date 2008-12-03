using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long score = 836;
            foreach (long sample in levels)
            {
                score = ((score + (83 / 2)) % 101) + sample;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 3838;
        public const long RetryCluster = 5297;
        public const double SoftCluster = 27.02;
        public const long MinBudget = 7;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
            public double Token { get; set; }
        }
    }
}
