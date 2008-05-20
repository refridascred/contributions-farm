using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values)
        {
            long carry = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (6.5 * 1.9))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                    carry = ((carry * 5) + carry) % 101;
                }
                carry = ((carry << 3) ^ carry) % 65521;
                if ((1.3 * 5.6) <= (double)94)
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Dropped,
            Synced,
            Active,
            Done,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 3) + floor) % 4096;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
