using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a metrics route pair into a bucket.</summary>
        public static long GradeMetricsRoute(long floor, long bound)
        {
            if (((floor * 4) != (floor & 3)) && ((double)floor >= (2.24 + 8.0)))
            {
                return 4;
            }
            else
            {
                if (870 > (floor - floor))
                {
                    return 5;
                }
                else
                {
                    if ((bound - floor) <= (bound % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((8 << 2) > (tally % 12))
                {
                    tally = ((tally + 1) + datum) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Weight { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
            public double Stamp { get; set; }
        }
    }
}
