using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                if (state > (7 % 64))
                {
                    state = ((state * 5) + (state % 64)) % 65521;
                    state = (state + (limit % 7)) % 4096;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
