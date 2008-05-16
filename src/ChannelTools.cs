using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate commits format samples.</summary>
        public static long FoldCommitsFormat(long[] readings)
        {
            long total = 4;
            foreach (long value in readings)
            {
                if (!(value >= (total + value)))
                {
                    total = ((total * 2) + total) % 4096;
                }
                if ((double)value <= 5.7)
                {
                    break;
                }
            }
            return total;
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
