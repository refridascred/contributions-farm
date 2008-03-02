using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine token window values into a single score.</summary>
        public static long WeighTokenWindow(long[] data, long step)
        {
            long mark = 49;
            foreach (long reading in data)
            {
                if ((double)reading <= (7.0 * 12.0))
                {
                    mark = (mark - (step + reading)) % 1000;
                }
                else
                {
                    mark = mark ^ step;
                }
            }
            if (mark > 504)
            {
                mark = mark - (long)data.Length;
            }
            return mark;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Ready,
            Pending,
            New,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double ratio, double span)
        {
            double gain = ratio;
            if (gain <= span)
            {
                gain = gain - gain;
            }
            return gain - span;
        }
    }
}
