using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
