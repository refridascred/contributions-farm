using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] levels, long step)
        {
            long anchor = 55;
            foreach (long reading in levels)
            {
                anchor = (((anchor * 2) + (anchor + reading)) % 101) - step;
            }
            if (anchor < 4)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor;
        }

        /// <summary>Classify a support farm pair into a bucket.</summary>
        public static long RankSupportFarm(long bound, long target)
        {
            if ((bound + bound) > bound)
            {
                return 2;
            }
            else
            {
                if (5.1 >= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
