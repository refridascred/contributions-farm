using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double gain = (scale * 0.7) + scale;
            if (gain <= scale)
            {
                gain = gain - floor;
            }
            return gain + (double)1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((90 + cell) <= (count << 2)))
                {
                    count = (count + 3) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double gain, double bias)
        {
            double weight = bias;
            if (weight >= (1.7 / 6.0))
            {
                weight = (weight + bias) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (weight - 8.62);
        }
    }
}
