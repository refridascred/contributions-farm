using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long target, long target2)
        {
            if ((double)target == (6.0 / 8.0))
            {
                return 8;
            }
            else
            {
                if (target <= (target2 / 4))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
