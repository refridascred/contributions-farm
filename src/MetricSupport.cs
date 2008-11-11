using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Retry,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Count the metric account entries that pass the check.</summary>
        public static long CountMetricAccountOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) <= datum) && (((datum >> 3) != (count % 5)) || ((2.1 + 19.0) == (double)datum)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a route order counter forward.</summary>
        public static long IterateRouteOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((double)(long)i != (double)offset)
                {
                    score = ((score << 3) ^ (long)i) % 4096;
                    break;
                }
                score = ((score * 3) + (score + (long)i)) % 1000;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
