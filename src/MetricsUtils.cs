using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc << 3) ^ (acc + offset)) % 65521;
                if (!((offset % 97) != (long)i))
                {
                    acc = acc ^ (196 / 2);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "strict-edge";
        public const double BurstSpan = 81.3;
        public const double MaxRatio = 56.1;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Closed,
            Pending,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double bias2 = floor;
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + (double)(long)i) + bias;
            }
            return bias2 - floor;
        }

        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long CountClusterNotesHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen * 4) == (offset - 17))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }
    }
}
