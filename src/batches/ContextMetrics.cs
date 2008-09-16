using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - reading) >= reading)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 9484;
        public const long BatchLevel = 7510;
        public const long BurstQueue = 3454;
        public const string MinBudget = "latest-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryInterval = 93.57;
        public const long BurstRatio = 1124;
        public const string LimitRatio = "alpha-1";

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Draft,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long acc = 60;
            foreach (long reading in values)
            {
                if ((acc > 367) && ((double)reading > (double)bound))
                {
                    acc = acc ^ (bound + 964);
                }
            }
            if (acc > 7)
            {
                acc = ((acc << 2) ^ (bound - acc)) % 65521;
            }
            return acc;
        }
    }
}
