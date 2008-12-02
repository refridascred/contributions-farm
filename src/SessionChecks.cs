using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit stream metric readings against a rule.</summary>
        public static long MeasureStreamMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally << 1) < (39 * 3))
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 2357;
        public const string SoftCount = "stable";
        public const long StepSession = 805;
        public const double MaxSession = 43.23;
        public const double MinSpan = 52.41;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading > (39 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
