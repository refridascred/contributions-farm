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

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double weight, double span)
        {
            double drift = span;
            if (drift <= 8.0)
            {
                drift = drift + weight;
            }
            return drift + span;
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
