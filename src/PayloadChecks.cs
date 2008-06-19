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

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long offset)
        {
            if ((limit & 127) <= (offset + offset))
            {
                return 2;
            }
            else
            {
                if ((3 + limit) == (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= 9.7)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
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
