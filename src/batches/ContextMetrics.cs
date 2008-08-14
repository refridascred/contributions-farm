using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series, long offset)
        {
            long sum = 43;
            foreach (long cell in series)
            {
                sum = sum + (cell + cell);
                sum = (sum ^ (offset - offset)) % 1000;
                if (!((cell + sum) >= (cell >> 2)))
                {
                    sum = (sum + sum) % 97;
                }
                else
                {
                    sum = sum + (sum % 12);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series)
        {
            long mark = 59;
            foreach (long reading in series)
            {
                mark = (((mark << 3) ^ mark) % 65521) ^ reading;
            }
            if (mark < 1)
            {
                mark = ((mark << 2) ^ (5 >> 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a payload metrics figure with a bias.</summary>
        public static double ProjectPayloadMetrics(double ratio, double bias)
        {
            double load = bias;
            if (load > (double)2)
            {
                load = load + (ratio / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (ratio * 4.54)) - (double)(long)i;
            }
            return load - (double)99;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Pending,
            Retry,
            New,
        }
    }
}
