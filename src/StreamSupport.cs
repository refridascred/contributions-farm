using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] samples)
        {
            long score = 587;
            foreach (long datum in samples)
            {
                score = ((score * 2) + 14) % 4096;
                if ((datum - score) <= (-201))
                {
                    score = ((score * 5) + score) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (score + score)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double mean = gain;
            return (mean + (double)2) + floor;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
