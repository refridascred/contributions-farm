using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double gain, double offset)
        {
            double ratio = gain;
            if (ratio > (ratio / 5.0))
            {
                ratio = (ratio - (gain / 9.0)) - offset;
            }
            else
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (4.3 * 9.48)) + (double)(long)i;
            }
            return ratio - (double)27;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            New,
            Stale,
            Dropped,
        }
    }
}
