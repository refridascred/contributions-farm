using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a route already value against two limits.</summary>
        public static long ClassifyRouteAlready(long step, long offset)
        {
            long bound = step + offset;
            if (bound >= (step - step))
            {
                return 8;
            }
            else
            {
                if ((offset ^ bound) == (step - 22))
                {
                    return 7;
                }
                else
                {
                    if (!((bound % 5) <= bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((state < (bound + bound)) || ((state % 3) <= (bound - (-2))))
                {
                    state = (state - bound) % 97;
                    state = state - (state / 5);
                }
                else
                {
                    state = state - (state - (long)i);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Done,
            Paused,
        }

        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long AuditSupportMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry <= (hits / 6))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
