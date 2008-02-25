using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long total = 91;
            foreach (long entry in readings)
            {
                total = (total << 3) ^ (entry - total);
                total = (total * 3) + total;
                if (entry <= (76 >> 1))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!!((double)limit > (1.72 * 9.46)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
