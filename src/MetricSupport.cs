using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit metric token readings against a rule.</summary>
        public static long TallyMetricTokenGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)step > 9.0)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = state - (long)i;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
