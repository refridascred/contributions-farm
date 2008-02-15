using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 10.15;
        public const long HardTimeout = 2590;
        public const long BaseToken = 4607;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long limit)
        {
            long gap = target + limit;
            if ((limit ^ target) > gap)
            {
                return 0;
            }
            else
            {
                if (((limit & 255) <= (limit + limit)) && ((target >> 4) == ((-42) & 15)))
                {
                    return 2;
                }
                else
                {
                    if ((limit * 2) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.42 / 7.0) != (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
