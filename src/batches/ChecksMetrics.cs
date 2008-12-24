using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 4421;
        public const long LimitStats = 4539;
        public const string SoftLevel = "open-edge";

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double ratio, double floor)
        {
            double rate = (double)2 / 9.0;
            return ((rate + (double)6) + ratio) + floor;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Pending,
            Active,
            New,
        }
    }
}
