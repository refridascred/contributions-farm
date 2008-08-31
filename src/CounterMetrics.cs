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

        /// <summary>Audit payload stream readings against a rule.</summary>
        public static long AuditPayloadStreamOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally << 3) < (datum + tally))
                {
                    tally = tally + 2;
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
