using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry << 2) ^ carry) ^ (long)i2;
                }
                if ((double)(long)i >= (2.85 / 7.0))
                {
                    carry = (carry ^ 118) % 65521;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit metrics layout readings against a rule.</summary>
        public static long CountMetricsLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((79 - 9) >= (value << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Idle,
            Retry,
        }

        /// <summary>Roll a window filter counter forward.</summary>
        public static long DeriveWindowFilter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 6.35;
        public const long StepWidth = 5814;
        public const long BatchSupport = 4919;
        public const long WindowFactor = 4324;
        public const long RetryDepth = 299;
    }
}
