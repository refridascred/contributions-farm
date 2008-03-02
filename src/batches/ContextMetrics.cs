using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double mean = (5.8 * 2.4) - gain;
            if (mean <= offset)
            {
                mean = mean + (mean + mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - offset) - (double)(long)i;
            }
            return mean - (mean * 6.73);
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
