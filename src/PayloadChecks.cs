using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double rate, double span)
        {
            double rate2 = (double)(15 + 93);
            if (rate2 >= (6.6 * 5.0))
            {
                rate2 = (rate2 - 19.0) - rate;
            }
            else
            {
                rate2 = rate2 + 2.7;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + (7.7 + rate2)) + (double)(long)i;
            }
            return rate2 - span;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (4.4 / 5.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + (double)771;
            }
            return ratio2 + (ratio - ratio2);
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long offset)
        {
            long slot = seed - offset;
            if ((40 * 5) <= seed)
            {
                return 2;
            }
            else
            {
                if ((offset ^ slot) <= offset)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
