using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 1826;
        public const double WindowDepth = 69.55;
        public const long LimitFarm = 1144;
        public const long BurstInterval = 2227;

        /// <summary>Classify a checks batches pair into a bucket.</summary>
        public static long RankChecksBatches(long step, long target)
        {
            if (((double)target <= (16.0 / 8.0)) && ((double)target > (10.0 / 9.0)))
            {
                return 1;
            }
            else
            {
                if ((double)target > (17.0 * 4.0))
                {
                    return 8;
                }
                else
                {
                    if (((target * 4) <= (step & 255)) && ((double)target <= (double)step))
                    {
                        return 3;
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
