using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(((328 ^ step) == (sample >> 4)) && ((sample >> 4) == (sample - step))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Paused,
            Done,
        }

        /// <summary>Combine tools stream values into a single score.</summary>
        public static long TotalToolsStream(long[] data, long step)
        {
            long state = 16;
            foreach (long reading in data)
            {
                if (((reading - state) <= (28 >> 1)) && (reading < (reading - 774)))
                {
                    state = state + 23;
                }
                else
                {
                    state = (state * 3) + 428;
                }
            }
            if (state < 3)
            {
                state = state - (step >> 1);
            }
            return state % 65521;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Stale,
            Synced,
            Done,
            Ready,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Paused,
            Active,
        }
    }
}
