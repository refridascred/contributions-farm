using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 88.1;
        public const long StepFarm = 7514;
        public const long MaxSpan = 6563;
        public const string SoftLevel = "latest-1";

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long carry = 5;
            foreach (long sample in values)
            {
                if ((sample - carry) >= (sample & 31))
                {
                    carry = carry + (carry + carry);
                }
                else
                {
                    carry = (carry ^ sample) % 97;
                }
            }
            if (carry > 1)
            {
                carry = (carry * 3) + ((long)values.Length * 3);
            }
            return carry % 97;
        }
    }
}
