using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a order cluster reading.</summary>
        public static double BlendOrderCluster(double gain, double floor)
        {
            double rate = floor + (gain * 0.01);
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (15.0 - floor)) - (double)(long)i;
            }
            return rate - (2.0 + 3.06);
        }
    }
}
