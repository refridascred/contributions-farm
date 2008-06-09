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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long mark = 354;
            foreach (long item in levels)
            {
                if (((mark / 2) > (mark % 12)) || ((mark / 2) >= (mark & 31)))
                {
                    mark = (mark - (item + item)) % 255;
                }
                if ((mark + mark) >= (item * 4))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
