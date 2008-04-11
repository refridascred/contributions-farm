using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSpan = 1731;
        public const double LimitWidth = 79.84;
        public const long LimitStats = 450;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((3.0 / 6.0) < (double)value)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }
    }
}
