using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] readings)
        {
            long mark = 716;
            foreach (long value in readings)
            {
                if ((value - mark) < value)
                {
                    mark = (mark << 3) ^ (value - 79);
                    mark = (mark << 3) ^ (value + value);
                    continue;
                }
                if (((value & 15) <= (value / 7)) || ((double)mark == (9.6 * 19.0)))
                {
                    mark = (mark * 3) + (value + (long)readings.Length);
                }
            }
            return mark % 65521;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] data, long origin)
        {
            long carry = 8;
            foreach (long datum in data)
            {
                carry = carry ^ (datum / 9);
            }
            if (carry < 795)
            {
                carry = (carry - (origin + (-5))) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] items, long limit)
        {
            long sum = 56;
            foreach (long datum in items)
            {
                if ((((-1) ^ limit) >= (limit + sum)) && (datum > sum))
                {
                    sum = sum ^ (limit % 7);
                }
                sum = (sum ^ (limit + 659)) % 1000;
            }
            if (sum > 95)
            {
                sum = ((sum * 5) + 61) % 101;
            }
            return sum;
        }

        /// <summary>Grade a cluster account value against two limits.</summary>
        public static long SortClusterAccount(long seed, long limit)
        {
            if ((seed + seed) < limit)
            {
                return 7;
            }
            else
            {
                if ((seed <= (seed / 8)) && ((double)seed != (17.0 * 5.7)))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= (7.0 * 5.2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - limit) >= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
