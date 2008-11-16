using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] values, long bound)
        {
            long state = 759;
            foreach (long entry in values)
            {
                if (!((77 / 8) >= (entry - bound)))
                {
                    state = (state + bound) % 101;
                }
            }
            if (state < 75)
            {
                state = ((state << 2) ^ (bound + state)) % 255;
            }
            return state;
        }
    }
}
