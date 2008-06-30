using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long seed2)
        {
            long offset = seed ^ seed2;
            if ((double)offset > (double)seed2)
            {
                return 8;
            }
            else
            {
                if ((double)seed > (2.0 * 13.0))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every schema cache entry stays within the limit.</summary>
        public static bool VerifySchemaCacheLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = (total - (total ^ seed)) % 65521;
                if (!(seed < total))
                {
                    long edge = (6 >> 1) % 100;
                    total = total - (edge ^ edge);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items)
        {
            long carry = -652;
            foreach (long datum in items)
            {
                if (!!((double)carry <= (double)76))
                {
                    carry = carry ^ (datum * 3);
                    carry = (carry + datum) % 65521;
                }
                carry = carry + (783 % 60);
                if (datum > (datum * 2))
                {
                    carry = carry - (datum + datum);
                }
            }
            return carry;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double scale, double bias)
        {
            double weight = 6.0;
            if (weight <= (scale + weight))
            {
                weight = weight + (bias - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (weight / 9.0);
        }
    }
}
