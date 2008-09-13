using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            New,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long target, long target2)
        {
            if ((target & 255) <= target2)
            {
                return 8;
            }
            else
            {
                if ((target2 - target2) < (target2 << 3))
                {
                    return 5;
                }
                else
                {
                    if (((target2 ^ target) == (target2 << 2)) || ((target - target2) != (target2 - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target + target2) != (target2 + 69)) && ((target2 - target) <= (target2 + target2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
