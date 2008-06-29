using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long floor)
        {
            long next = target - floor;
            if (((floor << 3) < (floor & 127)) || ((target ^ next) != (target % 3)))
            {
                return 1;
            }
            else
            {
                if ((94 & 3) <= (next + 6))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double gain = 8.0;
            if (gain > (2.68 / 5.0))
            {
                gain = (gain + (ratio / 3.0)) + offset;
            }
            return gain + (ratio + ratio);
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }
    }
}
