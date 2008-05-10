using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] levels, long origin)
        {
            long acc = 72;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length < (double)origin)
                {
                    acc = ((acc * 3) + entry) % 255;
                    acc = (acc - (origin << 1)) % 1000;
                }
                acc = (acc * 3) + ((-1) >> 1);
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepScore = 7444;
        public const long MinTimeout = 7329;
        public const double WindowNotes = 57.24;
        public const long LimitNotes = 6395;

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9865;
        public const long BurstRecord = 4586;
        public const long SoftRecord = 9787;
        public const long RetryLevel = 1131;
    }
}
