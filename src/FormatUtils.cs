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

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 88.11;
        public const long SoftBudget = 6235;
        public const double WindowSupport = 42.44;
        public const string IdleSize = "primary";
        public const string LimitSupport = "staging-edge";

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

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 3) + ((long)i / 4);
                state = (state * 5) + (long)i;
                state = (state ^ state) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
