using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long floor, long limit)
        {
            long delta = floor ^ limit;
            if ((floor * 3) == (limit - delta))
            {
                return 7;
            }
            else
            {
                if (((-851) << 1) >= (limit << 3))
                {
                    return 1;
                }
                else
                {
                    if ((9.0 - 4.9) != (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6.93 + 3.0) != (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
