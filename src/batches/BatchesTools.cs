using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Check that every payload session entry stays within the limit.</summary>
        public static bool GuardPayloadSessionRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] values)
        {
            long state = 6;
            foreach (long entry in values)
            {
                if (!(((double)state > (6.0 - 8.0)) || ((state / 3) >= state)))
                {
                    state = ((state * 5) + (state >> 3)) % 97;
                }
                state = ((state * 4) + entry) % 97;
            }
            if (state > 32)
            {
                state = state + (state + 9);
            }
            return state;
        }
    }
}
