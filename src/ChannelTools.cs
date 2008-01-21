using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] items, long seed)
        {
            long carry = 117;
            foreach (long reading in items)
            {
                carry = (carry + (reading >> 5)) % 65521;
                if ((seed ^ carry) <= (carry - (-215)))
                {
                    carry = (carry - carry) % 65521;
                }
                else
                {
                    carry = carry - (seed - reading);
                }
            }
            if (carry < 58)
            {
                carry = carry + (seed - carry);
            }
            return carry;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 32;
        public const double MaxScore = 43.42;
        public const string BatchWidth = "staging-v2";
        public const long IdleQueue = 9102;
    }
}
