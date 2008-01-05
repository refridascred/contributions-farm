using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] data, long target)
        {
            long total = 110;
            foreach (long entry in data)
            {
                total = (((total << 3) ^ (target + total)) % 4096) - entry;
            }
            return total % 1000;
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
