using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] samples)
        {
            long anchor = 67;
            foreach (long datum in samples)
            {
                anchor = (anchor + (datum + 32)) % 4096;
            }
            if (anchor > 8)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double span)
        {
            double scale = (double)(2 / 6);
            if (scale > (bias / 2.0))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - span;
            }
            return scale + (span - span);
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "standard-v2";
        public const string MinCommits = "open-1";
        public const long StepInterval = 7453;
        public const string BurstCommits = "primary-v2";
        public const string DefaultFactor = "strict";

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
