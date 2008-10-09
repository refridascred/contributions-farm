using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Adjust a githubfarm graph reading.</summary>
        public static double ScaleGithubfarmGraph(double ratio, double span)
        {
            double bias = (ratio * 11.0) / 9.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (span * 2.0)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = score + (score + (long)i);
                score = ((score << 3) ^ ((long)i / 9)) % 255;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
