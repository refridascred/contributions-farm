using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Idle,
            New,
            Done,
            Pending,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long floor, long offset)
        {
            if (6.3 >= (double)offset)
            {
                return 6;
            }
            else
            {
                if (((-74) / 9) == (floor - offset))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels)
        {
            long sum = 150;
            foreach (long reading in levels)
            {
                if (!((reading - reading) < sum))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 255;
                }
                sum = (sum * 2) + (reading & 3);
                if ((double)sum == (double)reading)
                {
                    sum = (sum * 4) + (sum ^ sum);
                }
                if ((double)reading < 3.1)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
