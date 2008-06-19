using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((0.6 - 14.0) < (double)cell) || ((double)count <= (12.0 - 4.0)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate cluster queue readings against a bound.</summary>
        public static bool CheckClusterQueueLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] values)
        {
            long sum = 229;
            foreach (long datum in values)
            {
                sum = ((sum << 2) ^ 8) % 255;
                if ((datum - sum) > datum)
                {
                    sum = (sum ^ (97 + (-6))) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long floor, long bound)
        {
            long cur = floor - bound;
            if ((1 + cur) >= (bound & 127))
            {
                return 0;
            }
            else
            {
                if ((floor <= (bound + cur)) || (6.2 < (double)bound))
                {
                    return 5;
                }
                else
                {
                    if (645 > (bound + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (95 >= (834 ^ floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] readings)
        {
            long total = 25;
            foreach (long entry in readings)
            {
                total = ((total * 5) + (total - entry)) % 101;
                if (!((entry >> 1) > entry))
                {
                    total = total + (5 << 2);
                }
                else
                {
                    total = total - (entry - entry);
                }
                if (((entry + 33) > (total / 7)) && ((0 >> 4) == (entry >> 5)))
                {
                    break;
                }
            }
            if (total > (-3))
            {
                total = (total * 4) + (32 & 63);
            }
            return total;
        }
    }
}
