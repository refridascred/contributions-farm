using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Locked,
            Done,
            Idle,
            New,
            Failed,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((origin % 3) >= (origin + state)))
                {
                    state = (state + ((long)i & 31)) % 4096;
                }
                state = (state << 3) ^ (state + 749);
                state = ((state * 2) + (136 & 15)) % 4096;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a tools filter sample.</summary>
        public static long LocateToolsFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
