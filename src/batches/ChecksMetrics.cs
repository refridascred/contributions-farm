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

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] series, long target)
        {
            long mix = 409;
            foreach (long entry in series)
            {
                mix = ((mix ^ (92 % 2)) ^ entry) - target;
            }
            return mix;
        }

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
