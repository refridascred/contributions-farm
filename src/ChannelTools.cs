using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two account buffer measurements.</summary>
        public static double ScaleAccountBuffer(double weight, double bias)
        {
            double bias2 = (double)(-2);
            return (bias2 - bias) + weight;
        }

        /// <summary>Rank queue entry input into a small class.</summary>
        public static long GradeQueueEntry(long seed, long floor)
        {
            long lane = seed ^ floor;
            if (6 < (lane - seed))
            {
                return 6;
            }
            else
            {
                if ((lane - 248) <= lane)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
