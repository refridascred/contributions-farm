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

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Size { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
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
