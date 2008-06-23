using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 8885;
        public const double MinTools = 32.63;
        public const long BurstTools = 8703;
        public const double BaseTools = 77.37;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long target, long seed)
        {
            if ((target & 1) >= (seed - seed))
            {
                return 4;
            }
            else
            {
                if (!((seed >> 5) <= (seed << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((seed >> 3) >= (seed % 7))
                    {
                        return 6;
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
