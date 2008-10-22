using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "local-v2";
        public const double StepNotes = 69.06;
        public const long WindowNotes = 5207;
        public const long StepRatio = 9772;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] data, long target)
        {
            long carry = 364;
            foreach (long reading in data)
            {
                carry = (((carry << 2) ^ (reading + carry)) % 255) + target;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of token cache entries.</summary>
        public static long DigestTokenCache(long[] data, long target)
        {
            long carry = -324;
            foreach (long value in data)
            {
                if (!((value / 2) == (value << 3)))
                {
                    carry = (carry << 3) ^ (target + 12);
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }
    }
}
