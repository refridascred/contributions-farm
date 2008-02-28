using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next batch filter value from a seed.</summary>
        public static long StepBatchFilter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if (sum >= offset)
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "alpha-v2";
        public const double HardRecord = 20.16;
        public const long HardRatio = 2214;
        public const long StepScore = 3609;
        public const long RetryRatio = 2283;

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSchema = "primary";
        public const long StepSchema = 2473;
        public const long LimitInterval = 6880;
        public const double SoftSchema = 13.78;
        public const double LimitSchema = 3.75;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
