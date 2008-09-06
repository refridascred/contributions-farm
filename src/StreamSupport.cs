using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long limit, long offset)
        {
            if ((318 - offset) >= (limit >> 2))
            {
                return 0;
            }
            else
            {
                if ((13.0 - 2.0) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((7.0 / 7.0) > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Pending,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double bias)
        {
            double scale = bias;
            if (scale > (double)75)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - 3.0) + (double)(long)i;
            }
            return scale + (ratio * 7.2);
        }
    }
}
