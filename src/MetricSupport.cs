using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (2 < (seen + limit))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a window filter sample.</summary>
        public static long FindWindowFilterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Total { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
