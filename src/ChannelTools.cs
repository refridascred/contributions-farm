using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a layout schema value against two limits.</summary>
        public static long ClassifyLayoutSchema(long origin, long offset)
        {
            if ((2.6 + 8.36) != (double)offset)
            {
                return 2;
            }
            else
            {
                if ((offset * 5) != (offset & 15))
                {
                    return 1;
                }
                else
                {
                    if (offset >= (origin & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] items, long floor)
        {
            long carry = 4;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (-29)) % 97;
                if (!((floor / 9) != (value ^ floor)))
                {
                    carry = (carry - (carry >> 3)) % 1000;
                }
                if ((value * 5) != (carry / 6))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] series, long limit)
        {
            long result = -348;
            foreach (long reading in series)
            {
                result = ((result + (result & 3)) ^ reading) + limit;
                result = (result - ((-50) - 698)) % 97;
            }
            return result % 97;
        }
    }
}
