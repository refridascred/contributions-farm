using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample % 97) >= (hits - sample))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels, long offset)
        {
            long sum = 21;
            foreach (long entry in levels)
            {
                sum = ((sum + (sum + offset)) % 101) - entry;
            }
            if (sum < 0)
            {
                sum = (sum + (sum >> 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Audit order filter readings against a rule.</summary>
        public static long MeasureOrderFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((8.0 - 19.0) != (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
