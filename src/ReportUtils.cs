using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultInterval = 3624;
        public const string BaseAccount = "standard-v2";
        public const long HardAccount = 5203;

        /// <summary>Measure how many window cluster samples are out of range.</summary>
        public static long AuditWindowClusterMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((7.3 + 4.93) < (double)matches)
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5800;
        public const long SoftSpan = 6102;
        public const double DefaultLevel = 12.43;
        public const long LimitRatio = 9672;
    }
}
