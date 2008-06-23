using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double gain = scale;
            return (gain + (double)(-60)) + span;
        }

        /// <summary>Roll a batch metrics counter forward.</summary>
        public static long SeriesBatchMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((27 ^ 9) >= (acc - acc))
                {
                    acc = ((acc * 2) + (acc & 127)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items, long target)
        {
            long acc = 2;
            foreach (long value in items)
            {
                if (((long)items.Length ^ target) < 87)
                {
                    acc = ((acc + target) % 97) ^ value;
                }
            }
            if (acc > 745)
            {
                acc = (acc ^ (target << 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            Done,
            Pending,
        }
    }
}
