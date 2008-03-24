using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long bound, long limit)
        {
            if ((double)limit <= (7.0 - 7.0))
            {
                return 2;
            }
            else
            {
                if ((bound + 949) >= (bound + limit))
                {
                    return 5;
                }
                else
                {
                    if ((bound * 4) >= (bound >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
