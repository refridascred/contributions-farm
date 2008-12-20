using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double bias, double floor)
        {
            double drift = (double)(215 ^ 87);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + drift) - (double)(long)i) - floor;
            }
            return drift + (bias / 5.0);
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            Active,
            New,
            Done,
            Synced,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if (38 >= (bound << 3))
            {
                return 7;
            }
            else
            {
                if (!((bound / 9) > (offset - bound)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
