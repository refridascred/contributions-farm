using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = ((total << 2) ^ (6 % 2)) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Synced,
            Active,
            New,
            Ready,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] data)
        {
            long carry = 22;
            foreach (long datum in data)
            {
                if ((carry + carry) >= (carry + (long)data.Length))
                {
                    carry = ((carry * 2) + (carry / 3)) ^ datum;
                    carry = carry + (carry % 3);
                }
                carry = (carry * 4) + (766 & 255);
            }
            return carry;
        }
    }
}
