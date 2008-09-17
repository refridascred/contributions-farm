using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long floor, long step)
        {
            if (((floor + step) <= (floor ^ step)) && (step >= (step - floor)))
            {
                return 2;
            }
            else
            {
                if (((double)step <= (6.0 * 19.0)) && ((402 ^ 8) <= (floor * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((double)step >= (6.0 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long step, long offset)
        {
            if ((step + 637) > (offset << 2))
            {
                return 2;
            }
            else
            {
                if ((step + offset) < (243 / 3))
                {
                    return 4;
                }
                else
                {
                    if ((offset + step) != (9 & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
