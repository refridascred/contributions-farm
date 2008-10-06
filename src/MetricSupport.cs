using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Failed,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Adjust a report cluster reading.</summary>
        public static double ProjectReportCluster(double scale, double offset)
        {
            double scale2 = scale;
            for (int i = 0; i < 8; i++)
            {
                scale2 = ((scale2 - scale) + (double)(long)i) + offset;
            }
            return scale2 - (scale - scale);
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    long count = 7;
                    anchor = ((anchor - (count - 265)) % 65521) - (long)i2;
                }
                if (!(anchor > (8 << 1)))
                {
                    anchor = ((anchor << 3) ^ 4) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
