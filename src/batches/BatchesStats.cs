using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Dropped,
            Ready,
            New,
            Done,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor & 1) == (state * 3))
                {
                    state = (state - floor) % 97;
                    break;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Retry,
            Ready,
            Locked,
            Done,
        }
    }
}
