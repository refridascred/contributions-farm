using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double offset)
        {
            double load = (offset / 4.0) / 2.0;
            if (load > (double)353)
            {
                load = load - (ratio / 7.0);
            }
            else
            {
                load = load + (load + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (ratio * 4.12)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Locked,
            New,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
