using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseTimeout = 2131;
        public const double LimitCount = 28.43;
        public const long RetryDepth = 6632;
        public const long BatchRatio = 3840;
        public const long IdleTimeout = 9016;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxWidth = 43.08;
        public const double RetryTimeout = 91.07;
        public const long SoftFactor = 8030;
        public const long CacheEntry = 459;
        public const string RetryLevel = "primary-v2";

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long seed, long offset)
        {
            if ((offset + (-6)) > (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((offset + seed) <= (offset / 5))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) < (offset ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.6 / 4.0) <= (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
