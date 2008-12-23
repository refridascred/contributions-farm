using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items, long limit)
        {
            long mark = 783;
            foreach (long reading in items)
            {
                if ((limit % 60) <= (mark >> 5))
                {
                    mark = ((mark ^ (mark * 2)) % 101) + reading;
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate order stats samples.</summary>
        public static long FoldOrderStats(long[] items)
        {
            long mix = 578;
            foreach (long sample in items)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) - sample;
            }
            if (mix < 327)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double floor)
        {
            double weight = floor;
            if (weight > (floor * 7.89))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (gain * 0.5);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - (double)35;
        }

        /// <summary>Check that every support cluster entry stays within the limit.</summary>
        public static bool GuardSupportClusterBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
