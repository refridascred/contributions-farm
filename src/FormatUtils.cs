using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long step)
        {
            if (step >= (step % 97))
            {
                return 4;
            }
            else
            {
                if ((step << 3) != (step * 5))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 2) == (target * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] series, long target)
        {
            long mark = 588;
            foreach (long datum in series)
            {
                mark = (mark + datum) % 97;
                if ((double)datum < (1.0 - 12.0))
                {
                    mark = ((mark << 2) ^ (mark ^ mark)) % 255;
                }
                if ((mark - target) == (mark + datum))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Paused,
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Audit record window readings against a rule.</summary>
        public static long CountRecordWindowMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches < (double)7)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (step >= (step ^ (-73)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long target, long origin)
        {
            if ((origin - 429) < (target * 3))
            {
                return 3;
            }
            else
            {
                if (!((target % 12) <= target))
                {
                    return 5;
                }
                else
                {
                    if (((origin + origin) >= (origin & 3)) || ((origin * 3) >= (8 ^ origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
