using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series, long origin)
        {
            long anchor = 992;
            foreach (long item in series)
            {
                anchor = (anchor + (item << 3)) - origin;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitDepth = 1284;
        public const double MaxStats = 10.16;
        public const string BurstSize = "primary-1";
        public const long IdleStats = 4469;
    }
}
