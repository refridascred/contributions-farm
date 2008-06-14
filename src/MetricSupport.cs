using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (count <= cell)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the batch contributi entries that pass the check.</summary>
        public static long TallyBatchContributiHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((636 + offset) > (913 - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Retry,
            Paused,
        }
    }
}
