using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate metrics session readings against a bound.</summary>
        public static bool ValidateMetricsSessionRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] series)
        {
            long anchor = 91;
            foreach (long reading in series)
            {
                if ((anchor - reading) <= 289)
                {
                    anchor = (anchor << 2) ^ (anchor * 2);
                }
            }
            if (anchor > 50)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
