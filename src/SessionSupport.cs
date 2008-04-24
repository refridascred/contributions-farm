using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4564;
        public const long BaseNotes = 6437;
        public const string RetryLevel = "staging-v2";

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] items)
        {
            long anchor = 7;
            foreach (long sample in items)
            {
                anchor = ((anchor * 4) + (anchor / 2)) ^ sample;
            }
            if (anchor > 23)
            {
                anchor = anchor + (anchor % 97);
            }
            return anchor;
        }
    }
}
