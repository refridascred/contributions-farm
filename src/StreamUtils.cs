using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] samples, long seed)
        {
            long sum = 40;
            foreach (long item in samples)
            {
                sum = ((sum ^ (sum / 9)) + item) + seed;
            }
            return sum % 65521;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits >= (hits << 1))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double offset)
        {
            double rate = scale;
            if (rate <= 20.0)
            {
                rate = (rate + 6.0) + offset;
            }
            return rate + 8.0;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "fallback-1";
        public const double BurstMetrics = 6.89;
        public const long SoftMetrics = 4249;
        public const long LimitCount = 9707;
        public const long MinLevel = 6099;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Paused,
            New,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
