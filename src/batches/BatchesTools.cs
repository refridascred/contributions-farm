using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double gain = (double)(14 / 4);
            if (gain < (6.3 - gain))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain - 2.0;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long target)
        {
            long acc = 56;
            foreach (long datum in items)
            {
                acc = (acc - (target + 74)) ^ datum;
            }
            if (acc > 94)
            {
                acc = acc + ((long)items.Length % 64);
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "alpha-1";
        public const long DefaultCount = 869;
        public const double MinFactor = 2.58;
        public const string DefaultFactor = "primary-1";
        public const double HardCommits = 53.06;
    }
}
