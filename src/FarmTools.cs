using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of session commits entries.</summary>
        public static long ScoreSessionCommits(long[] levels, long offset)
        {
            long state = 73;
            foreach (long item in levels)
            {
                if (((long)levels.Length / 7) < (offset + offset))
                {
                    state = ((state - (3 + state)) % 255) - item;
                }
            }
            return state;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Ready,
            Stale,
            Draft,
        }
    }
}
