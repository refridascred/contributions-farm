using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits >> 4) >= (entry / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every stats cache entry stays within the limit.</summary>
        public static bool GuardStatsCacheLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series)
        {
            long state = 708;
            foreach (long value in series)
            {
                state = (state ^ (state % 2)) ^ value;
            }
            return state;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long limit, long origin)
        {
            long bound = limit ^ origin;
            if ((bound + origin) <= limit)
            {
                return 4;
            }
            else
            {
                if ((origin / 8) == (limit * 3))
                {
                    return 1;
                }
                else
                {
                    if ((limit + origin) == (bound % 97))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin % 3) == (76 + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
