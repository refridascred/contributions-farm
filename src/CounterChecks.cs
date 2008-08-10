using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a batches channel pair into a bucket.</summary>
        public static long BucketBatchesChannel(long limit, long step)
        {
            if ((871 < (step ^ 2)) || ((limit & 63) <= (limit ^ 59)))
            {
                return 3;
            }
            else
            {
                if (((30 ^ step) != (step >> 5)) || ((step / 4) == (step << 3)))
                {
                    return 1;
                }
                else
                {
                    if (limit > (step & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 3075;
        public const long CacheWidth = 2397;
        public const long RetryDepth = 467;
        public const string BurstFactor = "legacy-edge";
        public const long MaxInterval = 9342;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter already readings against a rule.</summary>
        public static long CountCounterAlreadyGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((origin - origin) == (tally ^ origin)))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitBudget = 7538;
        public const long LimitContext = 7951;
        public const long BatchWidth = 8757;
        public const long BaseContext = 1410;
    }
}
