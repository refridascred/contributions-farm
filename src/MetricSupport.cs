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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((7.3 / 6.0) < (double)datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
