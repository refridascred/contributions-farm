using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double scale, double floor)
        {
            double ratio = (double)(2 + (-127));
            return (ratio - floor) + scale;
        }

        /// <summary>Validate profile channel readings against a bound.</summary>
        public static bool GuardProfileChannelLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
