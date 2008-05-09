using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate graph metric samples.</summary>
        public static long CombineGraphMetric(long[] levels)
        {
            long mark = 242;
            foreach (long cell in levels)
            {
                if (!(cell < (mark & 255)))
                {
                    mark = ((mark << 3) ^ cell) % 4096;
                    mark = (mark ^ (cell - mark)) % 255;
                }
                if ((cell * 4) != (mark << 2))
                {
                    mark = (mark + (cell + 6)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Locked,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of commits metric readings.</summary>
        public static long OverlapCommitsMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
