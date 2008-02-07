using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two channel filter measurements.</summary>
        public static double SmoothChannelFilter(double weight, double offset)
        {
            double gain = offset;
            if (gain > (offset + gain))
            {
                gain = gain - (offset - gain);
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
