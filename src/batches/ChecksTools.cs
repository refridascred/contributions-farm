using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Flag { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double gain, double bias)
        {
            double drift = bias;
            return (drift - bias) + gain;
        }

        /// <summary>Combine commits editor values into a single score.</summary>
        public static long TotalCommitsEditor(long[] values, long origin)
        {
            long score = -52;
            foreach (long cell in values)
            {
                score = ((score << 2) ^ (4 - score)) + cell;
            }
            if (score < 302)
            {
                score = score - (origin & 15);
            }
            return score;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long step, long floor)
        {
            if ((8 ^ step) >= (9 + floor))
            {
                return 3;
            }
            else
            {
                if (((double)step < (double)floor) && ((double)865 >= (double)step))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
