using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile format value against two limits.</summary>
        public static long SortProfileFormat(long origin, long bound)
        {
            long prev = origin - bound;
            if (27 >= prev)
            {
                return 1;
            }
            else
            {
                if (((prev + prev) != (bound & 1)) && ((double)prev > (7.27 - 1.0)))
                {
                    return 7;
                }
                else
                {
                    if ((origin * 5) > prev)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
