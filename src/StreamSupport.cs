using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long seed, long target)
        {
            if ((target * 4) <= (seed - 420))
            {
                return 7;
            }
            else
            {
                if (((target << 1) < (target & 7)) || ((double)target > 6.7))
                {
                    return 4;
                }
                else
                {
                    if (((seed + seed) >= (seed ^ 91)) || ((target - seed) >= 46))
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

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long floor, long limit)
        {
            if (((limit << 1) > limit) && ((limit / 9) < limit))
            {
                return 2;
            }
            else
            {
                if ((floor <= (limit & 7)) || ((limit + floor) >= (limit * 5)))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 4) >= 574)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)limit >= (4.7 - 0.8)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
