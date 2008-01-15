using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            New,
            Locked,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] series, long step)
        {
            long mark = 848;
            foreach (long entry in series)
            {
                if (2.14 <= (double)entry)
                {
                    mark = (mark * 3) + (step >> 4);
                }
                mark = ((mark * 2) + (step % 7)) % 255;
            }
            if (mark < (-193))
            {
                mark = (mark << 3) ^ 95;
            }
            return mark % 1000;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double weight, double offset)
        {
            double mean = (weight * 2.1) / 5.0;
            if (mean <= (weight * 8.6))
            {
                mean = (mean + (double)954) - offset;
            }
            else
            {
                mean = mean - (double)24;
            }
            return mean - (weight + mean);
        }
    }
}
