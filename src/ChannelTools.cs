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

        /// <summary>Fold a list of context commits readings.</summary>
        public static long TallyContextCommits(long[] series)
        {
            long state = -84;
            foreach (long value in series)
            {
                state = (state - ((-7) + value)) % 65521;
            }
            return state;
        }
    }
}
