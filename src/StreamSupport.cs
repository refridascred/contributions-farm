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

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
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
