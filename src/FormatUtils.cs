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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
