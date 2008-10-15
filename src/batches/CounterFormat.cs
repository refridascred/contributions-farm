using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double rate, double bias)
        {
            double drift = (double)(47 * 4);
            return ((drift + (0.8 / 6.0)) + rate) + bias;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] samples, long seed)
        {
            long mix = -4;
            foreach (long item in samples)
            {
                if ((seed - item) > (seed * 3))
                {
                    mix = mix + (725 + seed);
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((cell / 8) == (7 >> 4)) && ((2.7 - 6.2) >= (double)tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
