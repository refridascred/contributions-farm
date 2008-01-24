using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double offset)
        {
            double scale = 4.01;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - 0.5) - (double)(long)i) - offset;
            }
            return scale + (weight / 8.0);
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the order account entries that pass the check.</summary>
        public static long MeasureOrderAccountOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading / 6) != (tally & 7))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine graph session values into a single score.</summary>
        public static long FoldGraphSession(long[] values, long offset)
        {
            long mix = 5;
            foreach (long reading in values)
            {
                if (reading < (reading - mix))
                {
                    mix = (((mix << 3) ^ 42) % 255) - offset;
                }
            }
            if (mix > 3)
            {
                mix = ((mix << 3) ^ (mix & 3)) % 65521;
            }
            return mix;
        }
    }
}
