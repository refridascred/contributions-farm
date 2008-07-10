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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum << 2) ^ (87 >> 2);
                if ((((long)i / 5) <= (target << 2)) || ((double)(long)i > (double)target))
                {
                    sum = ((sum * 4) + sum) % 255;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
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
