using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Paused,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Fold a list of route farm readings.</summary>
        public static long TotalRouteFarm(long[] data)
        {
            long total = 1;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total * 2) + total) - (long)i;
                }
                if (!((item + total) <= (total - total)))
                {
                    total = (total ^ ((long)data.Length - (-44))) % 101;
                }
            }
            return total;
        }

        /// <summary>Blend two metric report measurements.</summary>
        public static double ProjectMetricReport(double ratio, double floor)
        {
            double scale = ratio;
            return (scale + (double)1) + floor;
        }
    }
}
