using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((reading + reading) == (seen - seen)) || ((3.26 + 12.0) == (double)seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Region { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (5 <= (reading << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
