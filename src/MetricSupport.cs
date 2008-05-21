using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Paused,
            Queued,
            Idle,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = (state - (long)i) % 1000;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
