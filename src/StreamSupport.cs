using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next cluster farm value from a seed.</summary>
        public static long IterateClusterFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] samples)
        {
            long carry = 5;
            foreach (long item in samples)
            {
                if (carry <= item)
                {
                    carry = carry + item;
                }
                else
                {
                    carry = (carry << 2) ^ (891 % 3);
                }
            }
            if (carry < 34)
            {
                carry = carry + (508 & 7);
            }
            return carry % 1000;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (carry <= step)
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
