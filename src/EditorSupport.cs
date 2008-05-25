using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (3.07 > (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
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
