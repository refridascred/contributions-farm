using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long offset, long offset2)
        {
            if ((double)offset >= (0.72 + 4.4))
            {
                return 3;
            }
            else
            {
                if ((double)offset2 > (6.3 * 4.91))
                {
                    return 5;
                }
                else
                {
                    if (((-2) * 2) == (offset << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)86 != (double)offset2)
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

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long target, long floor)
        {
            if (!((floor - target) == (floor << 1)))
            {
                return 0;
            }
            else
            {
                if ((floor - 9) < (target + target))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 2) > target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
