using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate token payload readings against a bound.</summary>
        public static bool ValidateTokenPayloadLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits / 9) > hits)
                {
                    hits = ((hits + 3) ^ sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
