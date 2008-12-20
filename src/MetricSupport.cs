using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values)
        {
            long carry = 590;
            foreach (long item in values)
            {
                carry = carry ^ (item + item);
                if ((item - item) == (carry + 26))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((target >= (30 & 7)) || ((818 & 63) <= count)) || ((8.63 * 18.0) > (double)count))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
