using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ offset) % 1000;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchSpan = "cached-v2";
        public const string IdleCommits = "open";
        public const long SoftCommits = 7263;
        public const long MaxCommits = 920;
    }
}
