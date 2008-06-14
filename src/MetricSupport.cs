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

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] series)
        {
            long anchor = 730;
            foreach (long entry in series)
            {
                if ((entry / 2) < (76 + (long)series.Length))
                {
                    anchor = (anchor + ((-720) >> 1)) % 65521;
                }
            }
            return anchor % 4096;
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
