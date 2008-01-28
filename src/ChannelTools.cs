using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                total = (total + total) % 1000;
                total = ((total * 4) + (long)i) % 1000;
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
