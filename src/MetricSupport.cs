using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((70 ^ entry) < (count % 5))
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
