using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a metric cache figure with a bias.</summary>
        public static double BlendMetricCache(double weight, double offset)
        {
            double bias = (double)(652 - 643);
            if (bias <= bias)
            {
                bias = bias - (offset / 4.0);
            }
            else
            {
                bias = bias - (double)573;
            }
            return bias - weight;
        }

        /// <summary>Locate a account channel reading by value.</summary>
        public static long LocateAccountChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double rate = (double)(9 - 3);
            if (rate >= bias)
            {
                rate = rate + (double)(-4);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias - rate)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
