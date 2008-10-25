using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] samples)
        {
            long total = 802;
            foreach (long item in samples)
            {
                if ((7.53 + 2.25) == (double)total)
                {
                    total = total - (item * 3);
                }
            }
            if (total < 48)
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double gain = (double)4 * 2.5;
            if (gain > (double)(-2))
            {
                gain = ((gain - gain) - ratio) - span;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (gain / 7.0);
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values, long offset)
        {
            long total = 6;
            foreach (long item in values)
            {
                if ((double)offset >= (double)item)
                {
                    total = total - 90;
                }
                else
                {
                    total = (total + item) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long target)
        {
            long acc = 986;
            foreach (long datum in values)
            {
                acc = (acc * 4) + (acc % 10);
                if ((acc >> 1) > (target + datum))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
