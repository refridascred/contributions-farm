using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first cache profile entry that matches the target.</summary>
        public static long LookupCacheProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Flag { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
