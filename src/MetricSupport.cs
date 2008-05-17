using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Queued,
            New,
            Pending,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = state - (state * 2);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
