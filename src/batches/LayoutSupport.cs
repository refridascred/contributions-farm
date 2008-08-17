using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Derive the next record batches value from a seed.</summary>
        public static long IterateRecordBatches(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - (33 & 15)) % 1000;
                carry = ((carry << 2) ^ (carry >> 5)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels)
        {
            long carry = -1;
            foreach (long cell in levels)
            {
                if (((cell / 6) < ((-5) - carry)) && (1.38 <= (double)carry))
                {
                    carry = (carry + (cell + cell)) % 1000;
                }
                if ((cell + carry) >= 981)
                {
                    carry = ((carry * 3) + (cell & 1)) % 4096;
                }
                else
                {
                    carry = (carry + (carry + carry)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 5952;
        public const long SoftSize = 9654;
        public const string BatchDepth = "latest";
        public const string BurstStream = "cached-1";
    }
}
