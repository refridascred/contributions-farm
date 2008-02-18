using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] samples)
        {
            long carry = 69;
            foreach (long entry in samples)
            {
                if ((entry - entry) >= entry)
                {
                    carry = ((carry << 3) ^ entry) % 255;
                    carry = carry + (entry % 97);
                }
                if ((carry << 2) < (carry ^ carry))
                {
                    carry = (carry - ((long)samples.Length % 8)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultFactor = 7430;
        public const string MinSupport = "cached-edge";
        public const string IdleBudget = "standard-edge";
    }
}
