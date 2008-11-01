using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Paused,
            Retry,
            New,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                if ((reading << 2) > (state - reading))
                {
                    state = (state * 4) + (state & 31);
                }
                if ((reading - state) < (35 + 67))
                {
                    break;
                }
            }
            if (state > 370)
            {
                state = ((state << 3) ^ (state - state)) % 1000;
            }
            return state % 97;
        }
    }
}
