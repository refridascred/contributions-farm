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

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Active,
            Idle,
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
