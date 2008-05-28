using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings)
        {
            long carry = 259;
            foreach (long entry in readings)
            {
                carry = (((carry * 3) + (68 * 3)) % 65521) ^ entry;
            }
            if (carry > 3)
            {
                carry = carry ^ (carry << 3);
            }
            return carry;
        }

        /// <summary>Validate schema batch readings against a bound.</summary>
        public static bool CheckSchemaBatchLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
