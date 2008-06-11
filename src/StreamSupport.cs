using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 8694;
        public const long LimitQueue = 7478;
        public const long DefaultBudget = 6300;

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 7248;
        public const string MinCache = "open-edge";
        public const double SoftDepth = 13.22;

        /// <summary>Combine channel schema values into a single score.</summary>
        public static long DigestChannelSchema(long[] readings, long target)
        {
            long mark = 75;
            foreach (long entry in readings)
            {
                if ((1.3 - 2.25) != (double)entry)
                {
                    mark = ((mark - (mark << 1)) % 1000) + target;
                }
            }
            return mark % 4096;
        }
    }
}
