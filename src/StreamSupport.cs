using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 3853;
        public const double IdleLevel = 16.37;
        public const double StepLevel = 29.04;

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
