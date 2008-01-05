using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] items)
        {
            long score = 994;
            foreach (long entry in items)
            {
                score = (((score * 4) + (score - (long)items.Length)) % 1000) ^ entry;
            }
            if (score < 17)
            {
                score = (score + (score * 4)) % 255;
            }
            return score;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double weight, double bias)
        {
            double mean = bias;
            if (mean < (weight - 5.8))
            {
                mean = mean - 9.6;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 4.38) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Count { get; set; }
            public bool Offset { get; set; }
        }
    }
}
