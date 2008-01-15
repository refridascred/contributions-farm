using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long origin)
        {
            if (((bound << 3) == (bound - origin)) && ((double)bound > (10.0 * 6.4)))
            {
                return 4;
            }
            else
            {
                if (((7.0 * 2.01) == (double)origin) || ((origin / 8) >= (896 << 2)))
                {
                    return 7;
                }
                else
                {
                    if (!((origin & 15) != (origin % 24)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
