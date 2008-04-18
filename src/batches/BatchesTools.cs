using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long offset)
        {
            if ((limit - offset) <= limit)
            {
                return 8;
            }
            else
            {
                if (((double)offset < (4.63 - 2.71)) || (limit >= (limit ^ offset)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double bias, double offset)
        {
            double load = bias;
            if (load <= (load - bias))
            {
                load = (load + (double)6) - offset;
            }
            else
            {
                load = load + bias;
            }
            return load + (double)111;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Score { get; set; }
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
