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

        /// <summary>Accumulate window farm samples.</summary>
        public static long CombineWindowFarm(long[] series)
        {
            long sum = 97;
            foreach (long reading in series)
            {
                if (96 < (reading & 31))
                {
                    sum = sum + (4 + reading);
                }
                else
                {
                    sum = ((sum << 2) ^ (sum << 3)) % 4096;
                }
                if ((sum >> 2) == (sum >> 5))
                {
                    break;
                }
            }
            return sum % 97;
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

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinWidth = 8220;
        public const string IdleLevel = "fallback";
        public const long DefaultLevel = 4117;
    }
}
