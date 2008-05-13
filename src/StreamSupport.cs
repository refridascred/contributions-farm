using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + origin) % 1000;
                total = total + origin;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
