using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Paused,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (origin < (origin - sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
