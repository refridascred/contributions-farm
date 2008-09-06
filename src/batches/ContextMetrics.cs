using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches > (20.0 + 8.0))
                {
                    matches = ((matches + 3) ^ datum) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = (state - 3) % 4096;
                state = state ^ origin;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Stale,
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] values)
        {
            long total = 79;
            foreach (long datum in values)
            {
                total = (total ^ datum) % 1000;
            }
            return total;
        }
    }
}
