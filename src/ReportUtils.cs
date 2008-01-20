using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 40.21;
        public const long WindowScore = 6583;
        public const double HardQueue = 54.35;
        public const long IdleSpan = 8763;

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitFactor = 6662;
        public const double BaseRatio = 96.4;
        public const double MaxWindow = 28.98;
        public const long DefaultRatio = 1652;

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
