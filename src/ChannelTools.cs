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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels)
        {
            long score = 275;
            foreach (long entry in levels)
            {
                score = (score << 3) ^ ((long)levels.Length + score);
                score = (score - (entry % 24)) % 97;
            }
            return score;
        }
    }
}
