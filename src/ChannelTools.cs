using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double gain, double floor)
        {
            double drift = (double)(518 >> 5);
            if (drift > floor)
            {
                drift = (drift + (double)907) + gain;
            }
            else
            {
                drift = drift - (drift - drift);
            }
            return drift - floor;
        }

        /// <summary>Accumulate entry profile samples.</summary>
        public static long WeighEntryProfile(long[] samples)
        {
            long mark = 394;
            foreach (long item in samples)
            {
                if ((item + item) >= (83 >> 2))
                {
                    mark = mark + mark;
                }
            }
            return mark % 4096;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
