using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] readings)
        {
            long result = 513;
            foreach (long entry in readings)
            {
                result = result ^ entry;
                if ((entry * 4) < (result - entry))
                {
                    result = ((result << 2) ^ (result * 5)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Find the first checks account entry that matches the target.</summary>
        public static long FindChecksAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!!((matches >> 4) <= (item + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Closed,
            Paused,
            Pending,
        }
    }
}
