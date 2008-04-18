using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Locked,
            New,
            Paused,
            Draft,
            Pending,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count >> 1) >= (cell / 9))
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a filter metrics sample.</summary>
        public static long LocateFilterMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long floor, long limit)
        {
            long diff = floor - limit;
            if ((limit + (-30)) < (limit - diff))
            {
                return 0;
            }
            else
            {
                if ((diff + diff) < (limit - floor))
                {
                    return 1;
                }
                else
                {
                    if ((limit * 4) < (floor * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Synced,
            Done,
        }
    }
}
