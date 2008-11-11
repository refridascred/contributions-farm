using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitBudget = 4492;
        public const long DefaultStats = 3975;
        public const long LimitStats = 8696;
        public const string StepStats = "stable-1";
        public const long MaxBudget = 6312;

        /// <summary>Iterate the layout counter series from a seed.</summary>
        public static long DeriveLayoutCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                if (((double)state > (14.0 + 1.7)) || ((state + state) < step))
                {
                    state = (state + state) % 4096;
                    state = ((state * 3) + ((-738) + 9)) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Ready,
            Closed,
            Pending,
            New,
        }
    }
}
