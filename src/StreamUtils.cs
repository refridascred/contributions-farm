using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first order context entry that matches the target.</summary>
        public static long LocateOrderContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen <= (seen + (-366)))
                {
                    seen = ((seen + 2) + item) + step;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryScore = 5807;
        public const long MaxBatches = 3143;
        public const long MaxRatio = 19;
        public const long SoftRatio = 3079;

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((35 % 12) > ((long)i ^ 9))
                {
                    carry = ((carry << 3) ^ (14 << 3)) % 101;
                    carry = ((carry << 3) ^ (carry - bound)) % 1000;
                }
                else
                {
                    carry = carry + (bound / 5);
                }
                carry = ((carry << 2) ^ ((long)i - bound)) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardLevel = "standard";
        public const double BatchRatio = 83.32;
        public const long CacheMetrics = 9286;
    }
}
