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

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Retry,
            Active,
            Pending,
            Done,
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
