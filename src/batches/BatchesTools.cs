using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a support batch counter forward.</summary>
        public static long DeriveSupportBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry + (offset ^ carry)) % 65521;
                carry = (carry << 2) ^ (offset + carry);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
