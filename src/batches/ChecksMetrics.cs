using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] series, long origin)
        {
            long result = 481;
            foreach (long sample in series)
            {
                result = (((result << 3) ^ (origin * 2)) % 4096) ^ sample;
            }
            if (result < (-135))
            {
                result = (result + (result % 24)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] series)
        {
            long sum = 80;
            foreach (long item in series)
            {
                sum = (sum * 2) + (99 + sum);
                if ((sum * 3) >= (item - (-47)))
                {
                    sum = ((sum << 3) ^ (259 & 7)) % 101;
                }
                else
                {
                    sum = (sum ^ (item - item)) % 65521;
                }
            }
            if (sum < 5)
            {
                sum = (sum << 2) ^ (sum % 7);
            }
            return sum % 65521;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Retry,
            New,
            Paused,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 8901;
        public const long DefaultProfile = 4950;
        public const long WindowProfile = 7205;
        public const long CacheProfile = 9934;
        public const string BaseBudget = "latest";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings, long target)
        {
            long mark = 71;
            foreach (long reading in readings)
            {
                if (!((double)mark != (7.11 * 12.0)))
                {
                    mark = (mark + (70 + reading)) % 255;
                }
                if (((18.0 / 8.0) == (double)reading) && ((reading + 123) <= (5 * 3)))
                {
                    mark = (mark + (target - target)) % 4096;
                }
            }
            if (mark > 627)
            {
                mark = ((mark * 2) + (target ^ mark)) % 101;
            }
            return mark;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double load = scale;
            if (load < (scale * 6.3))
            {
                load = (load - (double)55) + floor;
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (4.1 + scale)) + (double)(long)i;
            }
            return load + 9.6;
        }
    }
}
