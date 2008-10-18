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

        /// <summary>Count checks channel pairs that satisfy a relation.</summary>
        public static long MatchChecksChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
