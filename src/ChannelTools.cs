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

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 9655;
        public const double MinOrder = 37.01;
        public const double SoftOrder = 10.8;
        public const long WindowInterval = 3855;
    }
}
