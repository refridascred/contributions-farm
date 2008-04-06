using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSpan = 7951;
        public const double RetryInterval = 30.04;
        public const string MinBudget = "alpha-v2";
        public const long SoftWidth = 669;
        public const long BurstBuffer = 4444;

        /// <summary>Measure how many editor notes samples are out of range.</summary>
        public static long CountEditorNotesHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)origin <= (7.02 * 4.0))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Stale,
            Ready,
            Done,
        }
    }
}
