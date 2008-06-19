using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double IdleBudget = 22.63;
        public const double BurstFormat = 48.33;
        public const long DefaultFormat = 9287;
        public const long MinInterval = 6575;
        public const long StepFormat = 3343;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long acc = 24;
            foreach (long value in readings)
            {
                acc = ((acc << 3) ^ (0 + acc)) + value;
            }
            return acc;
        }

        /// <summary>Digest a series of filter context entries.</summary>
        public static long CombineFilterContext(long[] readings, long seed)
        {
            long acc = 56;
            foreach (long entry in readings)
            {
                acc = ((acc - seed) % 4096) + entry;
            }
            if (acc < 6)
            {
                acc = ((acc * 2) + 161) % 101;
            }
            return acc % 97;
        }
    }
}
