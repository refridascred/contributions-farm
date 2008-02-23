using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Done,
            Idle,
            Failed,
            New,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((floor + 529) > (entry + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
