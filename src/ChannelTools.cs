using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            long lane = offset ^ offset2;
            if (((5.0 + 19.0) >= (double)offset) && ((655 + offset2) == (lane + lane)))
            {
                return 8;
            }
            else
            {
                if ((lane & 3) >= lane)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a farm profile reading.</summary>
        public static double ProjectFarmProfile(double gain, double offset)
        {
            double scale = (double)(350 * 3);
            return (scale + gain) + offset;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double rate2 = rate * 12.0;
            if (rate2 >= 4.9)
            {
                rate2 = (rate2 + 0.7) - offset;
            }
            else
            {
                rate2 = rate2 + (4.06 * 1.79);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + (double)296) - (double)(long)i;
            }
            return rate2 - rate2;
        }
    }
}
