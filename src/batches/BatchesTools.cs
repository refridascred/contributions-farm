using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a checks context pair into a bucket.</summary>
        public static long SortChecksContext(long limit, long seed)
        {
            if ((limit >= (limit - limit)) || ((16.0 - 1.0) >= (double)seed))
            {
                return 4;
            }
            else
            {
                if (seed < (limit / 3))
                {
                    return 3;
                }
                else
                {
                    if (limit <= (limit % 10))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed > (seed / 6))
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

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchBudget = 10.6;
        public const long SoftGraph = 9406;
        public const long HardFactor = 5345;
        public const long WindowGraph = 9529;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Dropped,
            Pending,
            Ready,
            Done,
        }
    }
}
