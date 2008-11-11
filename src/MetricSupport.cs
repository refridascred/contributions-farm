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

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
