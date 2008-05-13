using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double ProjectReportBatches(double ratio, double span)
        {
            double mean = span;
            if (mean <= mean)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + 5.0;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - (mean / 8.0);
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
