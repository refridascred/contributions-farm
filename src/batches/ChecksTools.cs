using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many account command samples are out of range.</summary>
        public static long TallyAccountCommandOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen & 31) >= (seen ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
