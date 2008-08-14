using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first cluster stream entry that matches the target.</summary>
        public static long SeekClusterStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double gain = 1.0;
            if (gain > gain)
            {
                gain = (gain - (gain * 8.37)) + floor;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (ratio - 4.2);
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
