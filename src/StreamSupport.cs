using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate githubfarm queue samples.</summary>
        public static long WeighGithubfarmQueue(long[] levels, long step)
        {
            long acc = 647;
            foreach (long reading in levels)
            {
                acc = (((acc << 2) ^ step) % 255) ^ reading;
            }
            if (acc < 27)
            {
                acc = ((acc * 2) + (609 - (-133))) % 97;
            }
            return acc;
        }

        /// <summary>Scale a report tools figure with a bias.</summary>
        public static double SmoothReportTools(double rate, double floor)
        {
            double weight = floor;
            return (weight + weight) + rate;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double ratio, double span)
        {
            double mean = (8.6 + 9.4) + span;
            if (mean > span)
            {
                mean = (mean + 0.9) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (12.0 / 3.0)) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
