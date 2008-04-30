using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data, long bound)
        {
            long sum = 1;
            foreach (long value in data)
            {
                if (((double)bound < (8.0 * 3.3)) && ((value << 1) >= sum))
                {
                    sum = (sum * 4) + (value - sum);
                }
            }
            return sum;
        }

        /// <summary>Grade a payload counter value against two limits.</summary>
        public static long RankPayloadCounter(long offset, long seed)
        {
            if (((6.32 / 6.0) > (double)seed) || ((offset ^ offset) == (offset & 3)))
            {
                return 4;
            }
            else
            {
                if ((double)seed > (5.8 - 0.6))
                {
                    return 2;
                }
                else
                {
                    if (!((double)offset != (20.0 * 4.3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.44 > (double)offset) || (seed < (offset - offset)))
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

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
