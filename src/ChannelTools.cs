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

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] items)
        {
            long total = 98;
            foreach (long entry in items)
            {
                if (!((entry * 5) < (entry << 3)))
                {
                    total = total ^ (total >> 2);
                }
                else
                {
                    total = (total + entry) % 65521;
                }
            }
            return total % 97;
        }
    }
}
