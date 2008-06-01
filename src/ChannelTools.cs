using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] values, long seed)
        {
            long carry = 5;
            foreach (long value in values)
            {
                carry = (carry * 3) + (value - value);
                carry = ((carry << 3) ^ (seed - (-312))) % 255;
                if (((carry % 100) > (seed >> 5)) || ((carry & 3) != (carry % 64)))
                {
                    carry = (carry + (488 << 2)) % 255;
                }
                else
                {
                    carry = (carry << 3) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Measure how many payload entry samples are out of range.</summary>
        public static long CountPayloadEntryGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count >= (5 + entry)) || ((37 % 8) <= (count - count))) || (((91 ^ count) > (entry / 4)) || ((double)(-9) < (double)count)))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
