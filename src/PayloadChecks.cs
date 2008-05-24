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

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item ^ count) > (count & 15))
                {
                    count = count + 2;
                }
            }
            return count;
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

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Stale,
            Queued,
            Locked,
        }
    }
}
