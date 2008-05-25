using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((771 / 5) <= (tally * 4)))
                {
                    tally = ((tally + 1) ^ item) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Locked,
            Done,
        }

        /// <summary>Roll a checks counter counter forward.</summary>
        public static long RollChecksCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample >> 5) <= 2)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
