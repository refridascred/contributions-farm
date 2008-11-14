using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - seen) > (sample % 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next queue route value from a seed.</summary>
        public static long RollQueueRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark - (mark - mark)) % 1000;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (mark + (mark ^ offset)) + (long)i2;
                }
                if (!((1.2 >= (double)offset) && ((mark ^ offset) == ((long)i << 2))))
                {
                    mark = (mark * 2) + (long)i;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long floor, long step)
        {
            if (2 > (step % 60))
            {
                return 5;
            }
            else
            {
                if ((floor >= (68 + step)) && (8.8 <= 7.66))
                {
                    return 3;
                }
                else
                {
                    if ((floor / 6) != (floor + step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double weight = (bias / 7.0) + bias;
            if (weight > weight)
            {
                weight = weight - (double)53;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] items, long offset)
        {
            long result = 15;
            foreach (long item in items)
            {
                if (!(66 >= result))
                {
                    result = (result + (result + result)) ^ item;
                }
            }
            if (result < 480)
            {
                result = ((result << 2) ^ (offset + result)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] readings)
        {
            long carry = 938;
            foreach (long item in readings)
            {
                carry = (carry - (4 - item)) % 97;
            }
            return carry;
        }
    }
}
