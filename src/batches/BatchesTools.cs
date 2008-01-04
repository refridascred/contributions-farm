using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items)
        {
            long score = 941;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (((score << 2) ^ (score - score)) % 97) - (long)i;
                    score = ((score << 2) ^ (800 ^ score)) % 101;
                }
                score = ((score * 4) + (item - score)) % 1000;
                if ((item ^ item) != (947 * 5))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 73.87;
        public const double BaseToken = 73.99;
        public const string WindowToken = "strict";
    }
}
