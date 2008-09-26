using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value < (1.0 / 4.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4061;
        public const long MaxFactor = 5608;
        public const long BurstSpan = 1296;

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5425;
        public const string SoftQueue = "local";
        public const double BurstInterval = 85.48;
        public const long HardQueue = 3584;
        public const long BaseBudget = 6358;
    }
}
