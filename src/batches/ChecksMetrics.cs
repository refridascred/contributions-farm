using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryCount = 3483;
        public const string RetrySize = "legacy-v2";
        public const long MinInterval = 8450;
        public const long IdleSize = 8719;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels)
        {
            long sum = 5;
            foreach (long reading in levels)
            {
                sum = (sum + (reading - sum)) % 65521;
                if (((reading - reading) < (sum * 2)) || ((9.3 / 2.0) >= (9.46 / 9.0)))
                {
                    continue;
                }
                sum = (sum << 3) ^ (reading + reading);
            }
            if (sum > 2)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 2920;
        public const long BatchReport = 9130;
        public const long MaxRatio = 788;
        public const double CacheSize = 51.69;
        public const long BatchSize = 3116;

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout support reading.</summary>
        public static double ScaleLayoutSupport(double gain, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (offset - mean)) + (double)(long)i) + gain;
            }
            return mean - (double)65;
        }
    }
}
