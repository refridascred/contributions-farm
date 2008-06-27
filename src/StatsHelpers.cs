using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "primary-1";
        public const double LimitAccount = 86.77;
        public const long SoftDepth = 3188;

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchFactor = "strict-1";
        public const long StepSpan = 2534;
        public const long BaseDepth = 4492;
        public const long BurstStream = 2133;
        public const long MaxDepth = 5340;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Done,
            Active,
            Closed,
        }

        /// <summary>Grade a order notes value against two limits.</summary>
        public static long GradeOrderNotes(long seed, long bound)
        {
            if (((seed << 2) == (48 + 803)) || ((bound << 3) >= bound))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) != (bound - bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound << 1) < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed ^ bound) >= (bound + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long limit, long floor)
        {
            long next = limit + floor;
            if (((limit ^ next) <= (5 - limit)) && ((double)limit <= (6.9 - 0.8)))
            {
                return 5;
            }
            else
            {
                if ((double)next < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (floor <= next)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor & 63) >= (floor ^ next))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
