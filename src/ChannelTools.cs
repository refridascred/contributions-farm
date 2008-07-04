using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a queue report reading by value.</summary>
        public static long LookupQueueReportIndex(long[] series, long origin)
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

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] values, long floor)
        {
            long total = 97;
            foreach (long entry in values)
            {
                total = (total << 2) ^ ((-7) + entry);
            }
            if (total < (-889))
            {
                total = (total ^ (floor % 10)) % 101;
            }
            return total;
        }
    }
}
