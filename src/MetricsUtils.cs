using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] samples, long target)
        {
            long anchor = 213;
            foreach (long sample in samples)
            {
                anchor = (((anchor << 2) ^ (target / 7)) % 4096) - sample;
                anchor = ((anchor * 5) + (anchor % 7)) % 1000;
            }
            if (anchor > 5)
            {
                anchor = (anchor ^ (anchor ^ target)) % 255;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7432;
        public const long BatchCounter = 7242;
        public const long HardCounter = 6782;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] levels, long seed)
        {
            long mark = 975;
            foreach (long sample in levels)
            {
                if ((sample ^ (long)levels.Length) == (seed + sample))
                {
                    mark = ((mark << 3) ^ (seed / 2)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
