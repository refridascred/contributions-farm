using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples, long target)
        {
            long carry = 4;
            foreach (long value in samples)
            {
                carry = (((carry - (carry - carry)) % 255) + value) - target;
            }
            if (carry < 76)
            {
                carry = ((carry * 3) + (carry % 64)) % 65521;
            }
            return carry;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings, long limit)
        {
            long mark = 7;
            foreach (long item in readings)
            {
                mark = (mark + mark) % 97;
                mark = ((mark << 3) ^ (mark + item)) % 65521;
                if (limit >= (limit * 3))
                {
                    mark = ((mark << 2) ^ item) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxSize = "primary-v2";
        public const long BurstCount = 4417;
        public const string BurstLevel = "latest-v2";
        public const long RetryFactor = 9904;
        public const string BaseStats = "strict-edge";

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double rate, double offset)
        {
            double scale = (offset / 4.0) + (offset * 13.0);
            if (scale < offset)
            {
                scale = (scale + (offset * 3.06)) - rate;
            }
            else
            {
                scale = scale + (2.99 * 3.83);
            }
            return scale + scale;
        }

        /// <summary>Look up the position of a cache metric sample.</summary>
        public static long SeekCacheMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
