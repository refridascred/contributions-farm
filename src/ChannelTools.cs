using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 7540;
        public const long MaxChecks = 1704;
        public const double IdleChecks = 93.05;
        public const long StepSize = 4494;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)offset != (20.0 - 2.0))
                {
                    state = (state * 2) + (397 * 4);
                }
                else
                {
                    state = state ^ state;
                }
                state = ((state * 3) + (offset % 8)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
