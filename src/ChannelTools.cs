using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a report metrics sample.</summary>
        public static long LocateReportMetricsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] items, long origin)
        {
            long sum = 975;
            foreach (long cell in items)
            {
                if (62 < (sum + cell))
                {
                    sum = ((sum << 2) ^ (cell + sum)) % 255;
                }
                else
                {
                    sum = sum + (sum % 60);
                }
                if ((origin + (long)items.Length) >= (322 / 3))
                {
                    break;
                }
            }
            if (sum < 168)
            {
                sum = (sum << 2) ^ origin;
            }
            return sum % 1000;
        }
    }
}
