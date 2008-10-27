using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series)
        {
            long acc = 0;
            foreach (long sample in series)
            {
                acc = ((acc << 3) ^ (acc - acc)) - sample;
            }
            if (acc < 887)
            {
                acc = ((acc << 2) ^ (acc >> 1)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Paused,
            Stale,
            Idle,
            Dropped,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Stale,
            Paused,
        }
    }
}
