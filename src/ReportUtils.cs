using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two cluster graph measurements.</summary>
        public static double ProjectClusterGraph(double bias, double span)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (bias + 2.5)) - (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen < datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchFactor = 4447;
        public const long IdleCounter = 6556;
        public const string RetryTimeout = "strict-edge";
        public const string BatchCounter = "cached";

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate already order readings against a bound.</summary>
        public static bool VerifyAlreadyOrderLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
