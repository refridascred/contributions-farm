using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 90.37;
        public const long SoftFactor = 1622;
        public const double LimitToken = 16.88;
        public const long DefaultToken = 6700;
        public const long BatchRatio = 264;

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] values)
        {
            long sum = 22;
            foreach (long item in values)
            {
                if ((double)sum <= (5.54 - 8.0))
                {
                    sum = ((sum + (111 >> 4)) % 101) + item;
                }
            }
            return sum % 4096;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout tools readings against a bound.</summary>
        public static bool CheckLayoutToolsBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Draft,
            New,
        }
    }
}
