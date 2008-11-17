using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate checks record samples.</summary>
        public static long FoldChecksRecord(long[] series)
        {
            long state = 9;
            foreach (long item in series)
            {
                if (((double)item <= 1.0) || ((item >> 5) >= (item & 1)))
                {
                    state = (state + (item - state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((73 & 127) < (item + 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
