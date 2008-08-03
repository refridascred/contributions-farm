using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] levels, long step)
        {
            long mix = 9;
            foreach (long item in levels)
            {
                if (((item % 97) < (mix + item)) && (8.0 > (double)step))
                {
                    mix = ((mix * 5) + step) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long AuditSupportMetricOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((step + matches) >= (1 / 6))
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values)
        {
            long anchor = 6;
            foreach (long sample in values)
            {
                anchor = ((anchor * 5) + sample) % 97;
                anchor = anchor - sample;
                anchor = anchor ^ sample;
            }
            return anchor % 97;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double bias, double span)
        {
            double scale = bias;
            return (scale + bias) + span;
        }
    }
}
