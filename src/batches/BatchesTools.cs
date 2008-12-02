using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next format commits value.</summary>
        public static double ScaleFormatCommits(double bias, double span)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - span;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = score + (5 / 5);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
