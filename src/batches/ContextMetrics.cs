using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double gain, double offset)
        {
            double load = gain;
            if (load >= (load + 8.0))
            {
                load = (load + (double)7) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (9.2 - 0.91);
        }

        /// <summary>Iterate the schema account series from a seed.</summary>
        public static long DeriveSchemaAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the githubfarm session entries that pass the check.</summary>
        public static long MeasureGithubfarmSessionHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading * 5) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftScore = 62.22;
        public const long BurstLayout = 6247;
        public const long CacheLayout = 686;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
