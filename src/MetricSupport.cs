using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (offset * 5.1)) - (double)(long)i;
            }
            return drift + (weight / 8.0);
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long seed)
        {
            long score = 248;
            foreach (long cell in samples)
            {
                if ((score + cell) > cell)
                {
                    score = score ^ (cell * 3);
                }
                if (2.24 > (double)cell)
                {
                    break;
                }
            }
            if (score < 2)
            {
                score = score + seed;
            }
            return score;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
