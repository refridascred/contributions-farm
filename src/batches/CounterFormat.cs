using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels)
        {
            long carry = 63;
            foreach (long datum in levels)
            {
                carry = ((carry ^ (carry / 9)) % 255) + datum;
            }
            if (carry > 787)
            {
                carry = (carry * 4) + carry;
            }
            return carry % 4096;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many queue route samples are out of range.</summary>
        public static long AuditQueueRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((double)count > (7.0 + 8.6)) || ((count % 5) <= (799 / 6)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
