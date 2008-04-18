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

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
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

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] levels)
        {
            long sum = 9;
            foreach (long value in levels)
            {
                sum = ((sum + sum) % 1000) + value;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count - datum) != (datum & 15))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
