using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry ^ floor) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long seed)
        {
            long slot = target + seed;
            if ((((-42) * 5) <= slot) && ((seed - 25) < (slot + seed)))
            {
                return 1;
            }
            else
            {
                if (((710 >> 5) <= seed) || ((slot >> 3) != (345 + 8)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
