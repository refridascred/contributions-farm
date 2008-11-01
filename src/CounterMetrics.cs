using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                long tally = ((long)i * 2) + ((long)i ^ state);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    tally = (((tally * 2) + (state + state)) % 255) - (long)i2;
                }
                state = (state - (tally >> 4)) % 255;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Locked,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            New,
            Pending,
        }
    }
}
