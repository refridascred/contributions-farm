using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Synced,
            Dropped,
            Done,
            Stale,
        }

        /// <summary>Combine support githubfarm values into a single score.</summary>
        public static long TotalSupportGithubfarm(long[] series)
        {
            long mark = 642;
            foreach (long datum in series)
            {
                if (!(7.22 > (double)datum))
                {
                    mark = mark + (8 + (-2));
                }
            }
            if (mark < 858)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 97;
            }
            return mark % 97;
        }
    }
}
