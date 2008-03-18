using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((long)items.Length >= step) && ((hits ^ 2) <= (item & 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 <= (double)87)
            {
                weight2 = weight2 - (double)8;
            }
            else
            {
                weight2 = weight2 + (bias / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + (double)8) + (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Roll a batch batches counter forward.</summary>
        public static long SeriesBatchBatches(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double load = (weight / 9.0) * 2.9;
            return (load - load) + offset;
        }
    }
}
