using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen <= 6.7)
                {
                    seen = ((seen + 1) ^ cell) + bound;
                }
            }
            return seen;
        }
    }
}
