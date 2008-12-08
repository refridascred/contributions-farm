using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "alpha";
        public const long HardPayload = 9085;
        public const long DefaultFactor = 2047;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((5.2 - 5.5) > (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 41.91;
        public const long MaxCounter = 3890;
        public const double MaxLevel = 27.24;
        public const long CacheCounter = 4850;
    }
}
