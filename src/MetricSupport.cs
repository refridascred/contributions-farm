using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitInterval = 94.03;
        public const long BatchCache = 9993;
        public const double StepFactor = 88.87;
        public const string StepCache = "cached-edge";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((11.0 - 9.7) <= (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
