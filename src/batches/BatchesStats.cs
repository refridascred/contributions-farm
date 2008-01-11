using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long seed)
        {
            if (((36 - bound) > (bound - bound)) || ((449 + bound) >= (seed + bound)))
            {
                return 0;
            }
            else
            {
                if (((bound / 4) >= (bound * 4)) || ((-717) < (bound + seed)))
                {
                    return 5;
                }
                else
                {
                    if (57 >= (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstLevel = 4061;
        public const string BatchBudget = "open-1";
        public const string HardDepth = "staging-edge";
        public const long RetrySession = 8976;
        public const string BatchSession = "cached";

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long offset, long offset2)
        {
            if ((offset2 % 5) <= (offset2 & 31))
            {
                return 4;
            }
            else
            {
                if (offset2 >= 0)
                {
                    return 8;
                }
                else
                {
                    if ((offset * 3) <= offset2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((126 + offset) == (offset - offset2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
