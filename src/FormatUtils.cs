using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long floor, long bound)
        {
            if ((bound / 6) < (bound >> 2))
            {
                return 2;
            }
            else
            {
                if ((floor << 1) == (bound << 3))
                {
                    return 7;
                }
                else
                {
                    if (((double)(-94) > (double)bound) && ((floor << 1) > ((-9) % 10)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "strict-v2";
        public const long LimitStats = 3696;
        public const long SoftWidth = 177;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Pending,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Dropped,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftSpan = "alpha-v2";
        public const long LimitContributi = 7581;
        public const string WindowFactor = "primary-1";
        public const long BaseContributi = 9116;
        public const long StepDepth = 9390;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count ^ value) >= value)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
