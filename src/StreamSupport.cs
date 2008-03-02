using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Rank command order input into a small class.</summary>
        public static long RankCommandOrder(long seed, long step)
        {
            if ((seed - seed) >= (seed / 4))
            {
                return 8;
            }
            else
            {
                if ((double)step < (4.2 * 9.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long target)
        {
            if ((target > (498 + step)) || ((278 - 699) == (target >> 5)))
            {
                return 7;
            }
            else
            {
                if ((double)target < (8.26 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if (((34 - (-30)) >= (step << 3)) || ((target << 1) >= step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((4 << 1) < target)
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
    }
}
