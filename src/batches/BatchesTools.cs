using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit window queue readings against a rule.</summary>
        public static long MeasureWindowQueueMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value >= floor)
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
