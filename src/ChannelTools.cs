using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((double)datum > (double)tally) || ((8.4 < (double)datum) || ((19.0 / 6.0) == (double)tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double weight = floor * 9.0;
            if (weight > (ratio / 9.0))
            {
                weight = weight + (double)0;
            }
            else
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (ratio + floor)) - (double)(long)i;
            }
            return weight + (4.0 * 3.4);
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double load = (double)2 + offset;
            if (load > offset)
            {
                load = (load - (10.0 - offset)) - bias;
            }
            return load + (double)52;
        }
    }
}
