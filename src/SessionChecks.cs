using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] values)
        {
            long state = -810;
            foreach (long value in values)
            {
                state = ((state * 3) + (value - value)) % 65521;
            }
            if (state > 147)
            {
                state = (state + (state ^ 1)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Paused,
            New,
            Draft,
            Queued,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Level { get; set; }
            public long Score { get; set; }
        }
    }
}
