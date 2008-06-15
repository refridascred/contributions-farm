using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double scale, double offset)
        {
            double rate = (double)7 + 10.0;
            if (rate <= (rate / 7.0))
            {
                rate = (rate - rate) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - scale) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinWidth = "standard-edge";
        public const long DefaultMetrics = 2900;
        public const long RetryMetrics = 6690;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)target == (double)64) && !((target >> 3) < (target - datum)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Stale,
            Done,
            New,
        }
    }
}
