using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = state - (offset + state);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            New,
            Retry,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long bound)
        {
            if (((bound - target) <= bound) && ((bound - 3) == (bound ^ 4)))
            {
                return 2;
            }
            else
            {
                if (!((bound - 26) < bound))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
