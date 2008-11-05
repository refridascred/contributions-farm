using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryTimeout = 7166;
        public const long SoftBuffer = 443;
        public const long CacheRatio = 3848;
        public const long BurstScore = 2019;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((tally + entry) >= 3))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long origin, long step)
        {
            long slot = origin + step;
            if (((step >> 1) >= (67 + slot)) && ((slot + step) >= (slot - slot)))
            {
                return 6;
            }
            else
            {
                if (((step / 7) > (step + step)) || (slot <= (step + origin)))
                {
                    return 4;
                }
                else
                {
                    if ((2 * 5) >= (origin - slot))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin <= (double)slot)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm channel value against two limits.</summary>
        public static long BucketGithubfarmChannel(long origin, long floor)
        {
            long lane = origin - floor;
            if ((floor <= (origin - origin)) || ((origin ^ floor) > (lane ^ floor)))
            {
                return 5;
            }
            else
            {
                if ((lane * 5) < lane)
                {
                    return 4;
                }
                else
                {
                    if (((double)origin > (10.0 / 5.0)) || (0 >= origin))
                    {
                        return 6;
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
