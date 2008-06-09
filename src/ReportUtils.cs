using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "local-edge";
        public const long MinTimeout = 9892;
        public const long IdleCommand = 8492;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate graph layout readings against a bound.</summary>
        public static bool ValidateGraphLayoutRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (6.7 >= (double)tally)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Check that every order support entry stays within the limit.</summary>
        public static bool GuardOrderSupportRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
