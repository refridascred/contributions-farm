using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long target)
        {
            if (floor >= (target % 24))
            {
                return 4;
            }
            else
            {
                if (2.0 <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value * 5) <= ((-665) - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Retry,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Combine stream context values into a single score.</summary>
        public static long WeighStreamContext(long[] levels, long floor)
        {
            long acc = 70;
            foreach (long datum in levels)
            {
                acc = ((acc + (floor & 15)) % 97) + datum;
                if ((double)floor == (4.47 + 9.07))
                {
                    acc = acc + (acc - floor);
                }
                else
                {
                    acc = acc ^ 14;
                }
            }
            return acc;
        }
    }
}
