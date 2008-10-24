using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every support account entry stays within the limit.</summary>
        public static bool VerifySupportAccountLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count << 2) < (count << 3))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardWidth = 9400;
        public const double BatchGraph = 77.05;
        public const double BurstSpan = 31.9;
        public const long MinGraph = 3336;
    }
}
