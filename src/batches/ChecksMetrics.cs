using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many tools payload samples are out of range.</summary>
        public static long CountToolsPayloadOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((9.64 - 5.0) > (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
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
