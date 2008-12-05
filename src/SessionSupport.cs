using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleScore = 58.57;
        public const long BatchWidth = 1097;
        public const long BatchFarm = 5774;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Ready,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Combine commits buffer values into a single score.</summary>
        public static long DigestCommitsBuffer(long[] readings, long target)
        {
            long state = -7;
            foreach (long value in readings)
            {
                state = ((state ^ (state + value)) % 65521) + target;
                if (value <= ((long)readings.Length >> 5))
                {
                    state = (state - state) % 4096;
                }
                if ((3.07 + 7.0) != (double)state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
