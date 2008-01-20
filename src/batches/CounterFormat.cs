using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - (long)items.Length) >= (value - 984))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch cluster samples.</summary>
        public static long WeighBatchCluster(long[] levels, long seed)
        {
            long carry = 21;
            foreach (long reading in levels)
            {
                carry = ((carry * 5) + (seed << 2)) % 4096;
                if (((double)seed < (8.18 - 0.5)) || (66 >= (reading - 1)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
