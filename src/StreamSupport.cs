using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank tools route input into a small class.</summary>
        public static long RankToolsRoute(long floor, long seed)
        {
            long edge = floor ^ seed;
            if ((floor < (edge + edge)) && ((seed ^ 0) != (floor * 5)))
            {
                return 8;
            }
            else
            {
                if ((edge + floor) < 61)
                {
                    return 0;
                }
                else
                {
                    if (((edge >> 1) > 6) || ((floor * 3) >= 618))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor / 7) >= (edge % 16))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long limit, long limit2)
        {
            if ((double)limit <= (0.3 / 4.0))
            {
                return 6;
            }
            else
            {
                if (((limit - limit) >= 73) && (16.0 <= (double)limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit2 << 1) <= (limit - limit2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 1365;
        public const long IdleFactor = 1304;
        public const long WindowWidth = 8850;
        public const long HardOrder = 8819;
    }
}
