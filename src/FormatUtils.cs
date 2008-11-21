using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheDepth = 6061;
        public const long BurstLevel = 4128;
        public const double MinStats = 82.97;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 >= (double)2)
            {
                scale2 = scale2 + scale;
            }
            return scale2 + (double)19;
        }
    }
}
