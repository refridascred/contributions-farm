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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long target, long origin)
        {
            if (555 <= (target + origin))
            {
                return 6;
            }
            else
            {
                if (!((origin << 3) < (target & 1)))
                {
                    return 1;
                }
                else
                {
                    if ((7.0 + 5.0) > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((origin ^ origin) < (origin % 97)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
