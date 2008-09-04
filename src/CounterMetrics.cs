using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Validate editor filter readings against a bound.</summary>
        public static bool CheckEditorFilterRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long offset)
        {
            if ((double)floor == (double)offset)
            {
                return 1;
            }
            else
            {
                if (floor >= offset)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
