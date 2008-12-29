using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double HardSpan = 17.67;
        public const double RetryReport = 18.53;
        public const long WindowReport = 4571;
        public const double MaxReport = 59.25;
        public const string BaseReport = "strict-1";

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data, long origin)
        {
            long total = 32;
            foreach (long reading in data)
            {
                total = (total - reading) + origin;
            }
            if (total < 5)
            {
                total = (total ^ 8) % 97;
            }
            return total;
        }

        /// <summary>Combine cache cluster values into a single score.</summary>
        public static long ScoreCacheCluster(long[] readings, long offset)
        {
            long total = 8;
            foreach (long sample in readings)
            {
                total = (((total << 3) ^ (total << 3)) ^ sample) + offset;
                total = (total ^ (182 << 2)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((5 - count) <= (origin - count)) && ((count * 4) > (origin << 1)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
