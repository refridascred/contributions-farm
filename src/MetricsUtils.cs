using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data)
        {
            long acc = 38;
            foreach (long item in data)
            {
                if ((item + acc) <= acc)
                {
                    acc = (acc + (acc + acc)) % 101;
                }
                if (!((double)item <= (3.7 * 0.4)))
                {
                    acc = (acc ^ (acc >> 1)) % 255;
                }
            }
            if (acc < 77)
            {
                acc = (acc + (acc ^ acc)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Pending,
            Done,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((6.5 - 6.4) <= (double)matches)
                {
                    matches = ((matches + 1) ^ item) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((938 & 1) < (item + bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
