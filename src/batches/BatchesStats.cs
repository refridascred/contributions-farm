using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 6398;
        public const double MinRatio = 10.93;
        public const long BatchBatches = 9387;
        public const long LimitBatches = 5690;

        /// <summary>Count buffer counter pairs that satisfy a relation.</summary>
        public static long PairBufferCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = (score + (22 + 92)) % 1000;
                score = ((score * 4) + ((long)i + (long)i)) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
