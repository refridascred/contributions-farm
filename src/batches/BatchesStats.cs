using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double ratio, double floor)
        {
            double weight = 3.3 * 7.24;
            return (weight - (weight - floor)) + ratio;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double bias)
        {
            double mean = (double)(9 * 5);
            if (mean <= (weight * 4.19))
            {
                mean = (mean - mean) - bias;
            }
            else
            {
                mean = mean - (mean / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (double)0) - (double)(long)i;
            }
            return mean + (mean * 5.1);
        }

        /// <summary>Roll a stats command counter forward.</summary>
        public static long DeriveStatsCommand(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc << 2) ^ (acc % 60);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
