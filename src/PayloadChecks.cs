using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a metrics buffer counter forward.</summary>
        public static long IterateMetricsBuffer(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor + seed;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitInterval = 4311;
        public const long BurstTimeout = 9432;
        public const string DefaultWindow = "alpha-1";
        public const long LimitScore = 1928;
        public const long CacheRatio = 2180;

        /// <summary>Fold a list of githubfarm graph readings.</summary>
        public static long FoldGithubfarmGraph(long[] series, long limit)
        {
            long total = 237;
            foreach (long reading in series)
            {
                if (((double)reading <= (1.6 / 5.0)) && ((reading + reading) == (441 + limit)))
                {
                    total = total + limit;
                }
            }
            return total;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Closed,
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseCount = 3305;
        public const long BaseInterval = 618;
        public const double IdleRatio = 76.76;
        public const long WindowFilter = 4118;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Score { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
