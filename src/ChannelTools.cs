using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 5) + (target >> 5)) % 255;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] levels, long floor)
        {
            long carry = 879;
            foreach (long reading in levels)
            {
                if ((339 ^ 7) > reading)
                {
                    carry = carry ^ floor;
                }
                if (!((floor ^ floor) >= floor))
                {
                    break;
                }
            }
            if (carry > 73)
            {
                carry = (carry - 267) % 65521;
            }
            return carry % 1000;
        }
    }
}
