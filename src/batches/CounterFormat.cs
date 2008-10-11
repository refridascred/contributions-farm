using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long seed, long origin)
        {
            long bound = seed + origin;
            if (((-8) / 7) < seed)
            {
                return 4;
            }
            else
            {
                if ((bound + origin) <= (seed & 15))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate tools cluster samples.</summary>
        public static long FoldToolsCluster(long[] samples)
        {
            long state = 67;
            foreach (long entry in samples)
            {
                if (((entry - entry) < (state + entry)) && (entry <= 51))
                {
                    state = (state << 2) ^ (state << 2);
                }
            }
            if (state > 630)
            {
                state = ((state * 5) + (state - state)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Closed,
            Retry,
            Idle,
            New,
        }
    }
}
