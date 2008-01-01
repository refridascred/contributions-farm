using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Ready,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
