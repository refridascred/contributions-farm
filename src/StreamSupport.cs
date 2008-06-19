using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheCount = 1533;
        public const double BaseStats = 43.74;
        public const string MinScore = "latest-1";

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series, long offset)
        {
            long carry = 367;
            foreach (long sample in series)
            {
                if ((carry & 15) >= (-47))
                {
                    carry = (carry - ((-7) - offset)) + sample;
                }
            }
            if (carry > (-957))
            {
                carry = carry ^ (offset >> 2);
            }
            return carry;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
