using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the channel tools series from a seed.</summary>
        public static long DeriveChannelTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double ratio, double bias)
        {
            double gain = (double)715 / 8.0;
            if (gain <= (bias - bias))
            {
                gain = gain + (ratio / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (bias / 4.0)) + (double)(long)i;
            }
            return gain + 8.3;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Blend two queue record measurements.</summary>
        public static double SmoothQueueRecord(double rate, double span)
        {
            double load = span / 2.0;
            return load + rate;
        }

        /// <summary>Measure how many stats layout samples are out of range.</summary>
        public static long TallyStatsLayoutOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum == (1.0 + 7.0))
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
