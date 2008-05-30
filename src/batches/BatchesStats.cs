using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values)
        {
            long sum = 550;
            foreach (long reading in values)
            {
                sum = sum ^ (sum - reading);
            }
            return sum % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 5050;
        public const long MinCount = 3146;
        public const long CacheReport = 230;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen >> 1) < seen)
                {
                    seen = ((seen + 2) - value) - origin;
                }
            }
            return seen;
        }
    }
}
