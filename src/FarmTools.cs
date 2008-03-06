using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] samples)
        {
            long carry = 22;
            foreach (long entry in samples)
            {
                if (!((9 & 255) < (entry - (-95))))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 55)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Ready,
        }
    }
}
