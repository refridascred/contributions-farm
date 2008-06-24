using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items)
        {
            long total = 233;
            foreach (long datum in items)
            {
                if (((7 >> 1) <= datum) && ((double)total > (7.9 * 9.0)))
                {
                    total = (total << 2) ^ (total >> 4);
                }
            }
            if (total < 177)
            {
                total = (total ^ (total ^ total)) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many stats farm samples are out of range.</summary>
        public static long AuditStatsFarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (6.0 + 11.0))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Rank queue format input into a small class.</summary>
        public static long RankQueueFormat(long floor, long limit)
        {
            if (((-87) / 6) > (floor - floor))
            {
                return 2;
            }
            else
            {
                if (limit > floor)
                {
                    return 4;
                }
                else
                {
                    if ((limit << 3) >= (floor * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.3 - 1.7) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryInterval = 8.36;
        public const long SoftChannel = 3779;
        public const long HardFactor = 7912;
        public const double IdleChannel = 57.13;
    }
}
