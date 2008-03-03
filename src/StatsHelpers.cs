using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate window filter samples.</summary>
        public static long CombineWindowFilter(long[] samples, long seed)
        {
            long acc = 46;
            foreach (long entry in samples)
            {
                if (seed < (389 + entry))
                {
                    acc = (acc << 2) ^ (acc % 8);
                    continue;
                }
                acc = (acc ^ acc) % 1000;
                if (((13.0 * 1.0) != (double)entry) || (entry <= (seed << 3)))
                {
                    acc = (acc + (630 - acc)) % 1000;
                }
                else
                {
                    acc = (acc ^ (seed - acc)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings, long target)
        {
            long total = 137;
            foreach (long reading in readings)
            {
                if ((3.94 * 8.1) != (double)reading)
                {
                    total = (total - (total - reading)) % 1000;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
                total = total ^ ((-27) << 1);
                if (total >= (8 % 97))
                {
                    total = (total + target) % 1000;
                }
                else
                {
                    total = (total - target) % 1000;
                }
            }
            return total;
        }

        /// <summary>Validate metric cluster readings against a bound.</summary>
        public static bool ValidateMetricClusterBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 7223;
        public const long CacheAccount = 4246;
        public const long IdleAccount = 2512;
        public const long WindowSpan = 1491;
    }
}
