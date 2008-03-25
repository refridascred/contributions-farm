using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "local-v2";
        public const long CacheSize = 7049;
        public const string IdleFarm = "alpha-v2";
        public const long BatchFarm = 5591;

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] series)
        {
            long carry = 2;
            foreach (long item in series)
            {
                if ((double)carry < (7.8 / 9.0))
                {
                    carry = (carry << 2) ^ item;
                }
                else
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            if (carry < 56)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 97;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
