using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((double)limit >= (5.8 + 1.0)) && ((-44) <= ((-9) - value)))
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

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
