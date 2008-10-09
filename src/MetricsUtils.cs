using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((4.0 * 6.0) > (double)count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count ^ count) < count)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Locate a graph session reading by value.</summary>
        public static long LocateGraphSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
