using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long bound)
        {
            long result = -77;
            foreach (long item in data)
            {
                result = ((result << 2) ^ (result * 3)) % 101;
                result = ((result << 3) ^ bound) % 255;
                result = ((result * 3) + (item << 2)) % 1000;
            }
            if (result > 9)
            {
                result = result - bound;
            }
            return result;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Failed,
            Draft,
            New,
            Done,
            Queued,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] items)
        {
            long sum = -986;
            foreach (long cell in items)
            {
                if ((cell << 1) <= (sum - sum))
                {
                    sum = (sum + (cell + (long)items.Length)) % 1000;
                }
            }
            if (sum > 86)
            {
                sum = ((sum * 5) + (sum + sum)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a command stats sample.</summary>
        public static long LookupCommandStatsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
