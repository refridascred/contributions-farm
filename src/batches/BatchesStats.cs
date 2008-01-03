using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long floor, long target)
        {
            if ((target >> 2) >= (target * 4))
            {
                return 3;
            }
            else
            {
                if ((target - floor) == (target + target))
                {
                    return 0;
                }
                else
                {
                    if ((double)target > (4.0 * 8.18))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target + floor) >= floor) && ((target >> 2) != (target + target)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 9115;
        public const long LimitTools = 2365;
        public const string CacheDepth = "stable-v2";
    }
}
