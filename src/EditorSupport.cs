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

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double floor)
        {
            double rate = gain;
            if (rate >= rate)
            {
                rate = (rate + (gain + gain)) + floor;
            }
            else
            {
                rate = rate - (rate / 2.0);
            }
            return rate + rate;
        }
    }
}
