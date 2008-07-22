using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Pending,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double rate, double offset)
        {
            double gain = offset;
            if (gain >= (offset / 4.0))
            {
                gain = gain + (offset * 6.92);
            }
            return gain - (rate + offset);
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long offset)
        {
            if (floor < (811 + floor))
            {
                return 5;
            }
            else
            {
                if ((floor > (offset & 1)) && ((813 - offset) <= (offset - offset)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
