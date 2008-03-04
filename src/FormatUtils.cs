using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Ready,
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support schema readings against a bound.</summary>
        public static bool VerifySupportSchemaBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit context already readings against a rule.</summary>
        public static long AuditContextAlreadyGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seed + 5) < (seed << 2))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
