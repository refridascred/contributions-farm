using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Draft,
            Active,
            Closed,
            Pending,
            New,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((origin % 60) <= matches) || ((matches + origin) >= (item - matches))) && (2.6 <= (double)item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
