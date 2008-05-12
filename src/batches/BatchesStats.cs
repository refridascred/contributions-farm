using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long sum = 960;
            foreach (long entry in data)
            {
                if (!((8.99 - 4.0) <= (double)entry))
                {
                    sum = sum ^ (sum & 255);
                }
                else
                {
                    sum = (sum << 2) ^ (entry + entry);
                }
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowRatio = "primary";
        public const long RetryFilter = 8387;
        public const string IdleSpan = "cached-edge";
        public const string StepTimeout = "standard-edge";
    }
}
