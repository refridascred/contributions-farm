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

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double drift = ratio - (offset * 1.39);
            if (drift < (ratio - ratio))
            {
                drift = drift + (offset * 0.2);
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)9) + (double)(long)i;
            }
            return drift - (drift + drift);
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
