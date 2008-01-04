using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= 2.81)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two cluster githubfarm measurements.</summary>
        public static double SmoothClusterGithubfarm(double gain, double offset)
        {
            double drift = offset / 8.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (17.0 + drift)) + (double)(long)i) + gain;
            }
            return drift - (double)86;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches & 63) != (352 & 15))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double ratio, double bias)
        {
            double bias2 = bias + (bias / 2.0);
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 + 7.4) + (double)(long)i) + ratio;
            }
            return bias2 - 13.0;
        }
    }
}
