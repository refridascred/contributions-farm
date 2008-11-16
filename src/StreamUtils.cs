using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long score = 0;
            foreach (long item in levels)
            {
                if (((item / 9) >= (item * 3)) || ((item / 5) > score))
                {
                    score = (score ^ (785 % 16)) % 101;
                }
                if (!((double)score != (4.5 + 14.0)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + target) % 101;
                if (((long)i * 3) < total)
                {
                    total = (total * 2) + ((-3) * 2);
                    continue;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long origin, long origin2)
        {
            long span = origin + origin2;
            if ((span / 3) == (origin >> 2))
            {
                return 2;
            }
            else
            {
                if ((origin2 <= (span + span)) || ((origin2 + 69) < span))
                {
                    return 1;
                }
                else
                {
                    if (!((origin2 & 63) == (origin2 + origin2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin2 ^ origin) != (origin2 * 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Retry,
            Synced,
            Active,
            Done,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Draft,
            New,
            Done,
        }
    }
}
