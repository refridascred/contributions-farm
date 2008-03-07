using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!!((value >> 2) != (73 * 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Done,
            Draft,
        }

        /// <summary>Look up the position of a contributi payload sample.</summary>
        public static long LookupContributiPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] levels, long limit)
        {
            long sum = 525;
            foreach (long item in levels)
            {
                sum = ((sum - limit) % 255) ^ item;
                if ((sum & 3) < sum)
                {
                    sum = sum - sum;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long AuditOrderCacheOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((9 + seen) > (seen * 5))
                {
                    seen = ((seen + 3) ^ entry) + bound;
                }
            }
            return seen;
        }
    }
}
