using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Closed,
            Done,
        }

        /// <summary>Iterate the counter channel series from a seed.</summary>
        public static long StepCounterChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                if ((20.0 / 2.0) == (double)state)
                {
                    state = state - (737 - target);
                    state = state ^ ((long)i ^ (long)i);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
