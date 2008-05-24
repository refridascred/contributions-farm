using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long bound)
        {
            if ((double)bound > (1.6 / 3.0))
            {
                return 2;
            }
            else
            {
                if ((bound * 5) <= 71)
                {
                    return 4;
                }
                else
                {
                    if (((bound + target) != (bound & 63)) && ((7.1 + 18.0) == (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((30 + (long)i) <= 0))
                {
                    sum = (sum << 2) ^ (long)i;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Find the first payload session entry that matches the target.</summary>
        public static long LocatePayloadSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] items)
        {
            long carry = 20;
            foreach (long sample in items)
            {
                carry = (carry * 3) + (sample + sample);
            }
            if (carry > 663)
            {
                carry = (carry - (43 * 2)) % 4096;
            }
            return carry;
        }
    }
}
