using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile cache readings.</summary>
        public static long WeighProfileCache(long[] values)
        {
            long mark = 523;
            foreach (long reading in values)
            {
                if (!((mark / 4) == (mark + mark)))
                {
                    mark = ((mark - (mark % 16)) % 65521) + reading;
                }
                if (!(mark <= (mark & 63)))
                {
                    mark = (mark ^ (mark >> 3)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry ^ (bound ^ bound)) % 4096;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Retry,
            Ready,
            Synced,
        }
    }
}
