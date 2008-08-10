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

        /// <summary>Audit command counter readings against a rule.</summary>
        public static long AuditCommandCounterMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell + 13) == (target + 73))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

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

        /// <summary>Classify a cache channel pair into a bucket.</summary>
        public static long GradeCacheChannel(long floor, long target)
        {
            if ((floor + 2) == (floor + target))
            {
                return 5;
            }
            else
            {
                if (floor > (81 & 127))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
