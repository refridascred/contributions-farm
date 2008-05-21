using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
