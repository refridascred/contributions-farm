using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long acc = 581;
            foreach (long cell in samples)
            {
                acc = (acc + acc) ^ cell;
            }
            if (acc < 504)
            {
                acc = (acc * 4) + (acc + (long)samples.Length);
            }
            return acc;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a queue filter figure with a bias.</summary>
        public static double ScaleQueueFilter(double gain, double span)
        {
            double load = (double)(4 * 3);
            if (load >= load)
            {
                load = (load + (double)707) + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (span * 7.56)) + (double)(long)i;
            }
            return load + load;
        }
    }
}
