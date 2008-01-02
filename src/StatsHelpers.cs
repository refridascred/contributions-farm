using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double bias)
        {
            double load = bias;
            return (load - (bias + bias)) + scale;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)1 < (double)bound)
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Queued,
            Retry,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of githubfarm already readings.</summary>
        public static long ScoreGithubfarmAlready(long[] series)
        {
            long mark = 95;
            foreach (long value in series)
            {
                if ((mark + (-375)) < (value * 5))
                {
                    mark = ((mark * 5) + (mark + mark)) % 101;
                }
            }
            if (mark < 1)
            {
                mark = ((mark << 2) ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 55.54;
        public const string CacheProfile = "latest-v2";
        public const long SoftWidth = 5576;
    }
}
