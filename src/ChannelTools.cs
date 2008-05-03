using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] readings, long offset)
        {
            long carry = 69;
            foreach (long value in readings)
            {
                carry = ((carry + 558) ^ value) - offset;
                carry = (carry ^ carry) % 4096;
            }
            if (carry < 808)
            {
                carry = carry - (carry >> 3);
            }
            return carry % 65521;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Synced,
            Done,
        }

        /// <summary>Combine payload stream values into a single score.</summary>
        public static long TotalPayloadStream(long[] values)
        {
            long total = 98;
            foreach (long item in values)
            {
                if ((total + item) <= (item ^ 829))
                {
                    total = (total - (total & 31)) % 255;
                    total = (total ^ (item + item)) % 4096;
                }
                else
                {
                    total = total + (total % 2);
                }
                total = ((total << 2) ^ (item + 5)) % 1000;
                if (((item + 0) >= (total * 3)) || ((total & 31) < total))
                {
                    total = (total - (total + total)) % 101;
                }
                else
                {
                    total = total ^ (total >> 4);
                }
            }
            if (total < 1)
            {
                total = (total << 2) ^ (68 - 9);
            }
            return total;
        }
    }
}
