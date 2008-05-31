using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Paused,
            Active,
            Done,
            Locked,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Validate token farm readings against a bound.</summary>
        public static bool CheckTokenFarmLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
