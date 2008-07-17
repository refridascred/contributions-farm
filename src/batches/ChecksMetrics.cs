using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)(long)i > (7.0 - 9.0))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two route tools measurements.</summary>
        public static double SmoothRouteTools(double weight, double floor)
        {
            double scale = floor;
            if (scale < scale)
            {
                scale = scale + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (weight / 7.0)) - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((seed >> 2) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "legacy-edge";
        public const long BatchChannel = 738;
        public const long WindowChannel = 4577;
        public const double StepInterval = 68.27;
        public const string HardChannel = "primary";
    }
}
