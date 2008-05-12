using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long target, long bound)
        {
            if ((target % 3) != (bound << 3))
            {
                return 8;
            }
            else
            {
                if (bound <= (bound - bound))
                {
                    return 4;
                }
                else
                {
                    if (!((6 / 3) > (target & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((offset >> 1) < count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] data)
        {
            long carry = 444;
            foreach (long value in data)
            {
                carry = ((carry << 3) ^ (carry / 9)) - value;
            }
            if (carry > 129)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of commits session readings.</summary>
        public static long PairCommitsSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
