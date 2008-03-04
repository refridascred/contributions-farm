using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstCount = "local-1";
        public const long MinLayout = 272;
        public const long DefaultBudget = 5764;
        public const long DefaultLayout = 494;
        public const long WindowInterval = 2259;

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels)
        {
            long carry = -4;
            foreach (long reading in levels)
            {
                if (!(((long)levels.Length - reading) <= carry))
                {
                    carry = ((carry * 5) + carry) % 101;
                }
            }
            if (carry < (-15))
            {
                carry = ((carry << 2) ^ (carry << 3)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings)
        {
            long acc = 398;
            foreach (long value in readings)
            {
                acc = ((acc << 2) ^ (value + value)) % 4096;
            }
            if (acc < 560)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }
    }
}
