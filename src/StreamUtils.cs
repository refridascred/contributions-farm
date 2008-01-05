using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 52.71;
        public const long DefaultQueue = 7130;
        public const string MaxQueue = "latest-edge";

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Pending,
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((295 % 5) > (sample + count))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels, long seed)
        {
            long sum = 6;
            foreach (long value in levels)
            {
                if (value > (68 >> 2))
                {
                    sum = (sum * 4) + (value * 3);
                }
                else
                {
                    sum = (sum << 2) ^ (7 % 12);
                }
                if ((seed / 6) <= (value - sum))
                {
                    sum = (sum << 2) ^ (value - seed);
                }
                if (((7.1 + 3.0) < (double)seed) || ((value >> 2) > (value ^ sum)))
                {
                    break;
                }
            }
            if (sum < 757)
            {
                sum = (sum + seed) % 65521;
            }
            return sum;
        }
    }
}
