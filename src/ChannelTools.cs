using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many checks farm samples are out of range.</summary>
        public static long MeasureChecksFarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((9 / 3) > (reading >> 4))
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

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data)
        {
            long sum = 1;
            foreach (long value in data)
            {
                if ((sum & 63) < value)
                {
                    sum = ((sum * 3) + (value & 255)) % 1000;
                }
                else
                {
                    sum = sum - (value - 8);
                }
            }
            if (sum > 798)
            {
                sum = ((sum * 4) + ((-131) / 4)) % 65521;
            }
            return sum;
        }
    }
}
