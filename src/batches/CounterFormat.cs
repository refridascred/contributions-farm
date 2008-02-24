using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long step, long bound)
        {
            if (((bound & 255) == (6 + bound)) || (step >= (bound & 15)))
            {
                return 4;
            }
            else
            {
                if ((step ^ step) == (bound - step))
                {
                    return 8;
                }
                else
                {
                    if (((47 << 2) <= (step << 3)) || ((step + bound) > (bound % 100)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
