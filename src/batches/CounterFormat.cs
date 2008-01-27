using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((9.92 * 6.7) > (double)sample)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSize = 9534;
        public const long IdleBuffer = 9969;
        public const double RetryCount = 33.0;

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
