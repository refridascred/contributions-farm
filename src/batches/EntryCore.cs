using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long limit, long floor)
        {
            if (limit >= (floor + limit))
            {
                return 4;
            }
            else
            {
                if (limit <= (737 + floor))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Dropped,
            Done,
            Paused,
            Retry,
        }
    }
}
