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

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 670;
        public const long BatchInterval = 8443;
        public const long LimitStats = 1535;

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
