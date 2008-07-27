using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Dropped,
            Closed,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = state ^ (826 % 64);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
