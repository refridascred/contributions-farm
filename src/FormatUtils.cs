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

        /// <summary>Digest a series of metrics account entries.</summary>
        public static long TallyMetricsAccount(long[] items)
        {
            long result = 19;
            foreach (long reading in items)
            {
                if ((reading % 7) >= reading)
                {
                    result = (result - (result ^ result)) % 101;
                }
                if (((1.06 / 8.0) >= (double)result) || (903 < (reading << 3)))
                {
                    result = (result ^ (result + result)) % 4096;
                }
                if (reading > (reading - result))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = result - result;
            }
            return result % 1000;
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
