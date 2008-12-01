using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the farm filter entries that pass the check.</summary>
        public static long AuditFarmFilterOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((seed + seed) == (sample - 82))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double scale = floor;
            if (scale < (double)(-22))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - floor;
            }
            return scale + 5.0;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Label { get; set; }
            public double Region { get; set; }
        }
    }
}
