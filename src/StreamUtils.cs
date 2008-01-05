using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstSize = 55.0;
        public const string MaxLevel = "cached-1";
        public const long MaxSpan = 8644;
        public const string IdleFactor = "staging";

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

        /// <summary>Rank checks profile input into a small class.</summary>
        public static long RankChecksProfile(long limit, long offset)
        {
            if (!((24 + offset) < 8))
            {
                return 0;
            }
            else
            {
                if ((limit / 7) < (offset & 63))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
