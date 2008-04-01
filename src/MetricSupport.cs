using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((8.5 - 17.0) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Project the next metrics stream value.</summary>
        public static double SmoothMetricsStream(double rate, double floor)
        {
            double ratio = rate;
            return (ratio + 8.88) + floor;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
