using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Paused,
            Locked,
            Closed,
            Dropped,
            Pending,
        }
    }
}
