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

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Draft,
            Ready,
        }
    }
}
