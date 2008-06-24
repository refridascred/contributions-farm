using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            New,
            Queued,
            Active,
            Retry,
            Dropped,
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
