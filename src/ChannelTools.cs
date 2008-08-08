using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinDepth = 9870;
        public const string StepScore = "stable-1";
        public const long RetryFormat = 2790;

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] samples, long floor)
        {
            long acc = -469;
            foreach (long entry in samples)
            {
                acc = ((acc ^ (acc % 100)) - entry) - floor;
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
