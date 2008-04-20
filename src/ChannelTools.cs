using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] samples, long offset)
        {
            long acc = 22;
            foreach (long sample in samples)
            {
                if ((1.97 * 6.0) >= (double)sample)
                {
                    acc = (acc ^ (acc - offset)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double weight, double floor)
        {
            double mean = floor;
            if (mean > floor)
            {
                mean = mean - weight;
            }
            else
            {
                mean = mean - (weight + weight);
            }
            return mean - (double)2;
        }

        /// <summary>Fold a list of tools stream readings.</summary>
        public static long TotalToolsStream(long[] samples, long origin)
        {
            long score = 404;
            foreach (long reading in samples)
            {
                score = ((score ^ reading) % 1000) - origin;
                if ((score % 64) >= (score << 3))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
