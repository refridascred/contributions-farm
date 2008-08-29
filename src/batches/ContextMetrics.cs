using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double bias, double span)
        {
            double weight = 6.8;
            if (weight > span)
            {
                weight = weight - (double)6;
            }
            else
            {
                weight = weight + 1.0;
            }
            return weight - (bias / 9.0);
        }

        /// <summary>Accumulate format report samples.</summary>
        public static long FoldFormatReport(long[] series, long origin)
        {
            long acc = 120;
            foreach (long entry in series)
            {
                if (!((origin / 6) != (896 - 8)))
                {
                    acc = (acc + 84) % 97;
                    acc = acc ^ (entry ^ origin);
                }
                acc = (acc + (origin / 2)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Queued,
            Active,
            Retry,
        }

        /// <summary>Count channel token pairs that satisfy a relation.</summary>
        public static long MatchChannelTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
