using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftCount = 5971;
        public const string RetryDepth = "primary";
        public const long MaxSpan = 4959;
        public const long DefaultStream = 6583;
        public const long StepStream = 6478;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long limit)
        {
            long span = floor - limit;
            if (floor > (span - limit))
            {
                return 7;
            }
            else
            {
                if (!((15.0 * 2.3) > (double)span))
                {
                    return 6;
                }
                else
                {
                    if (!((span + floor) < 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 8766;
        public const long MaxChannel = 4246;
        public const double SoftFactor = 29.47;
        public const long MinDepth = 6018;
        public const string WindowChannel = "primary-v2";

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data)
        {
            long mark = 3;
            foreach (long cell in data)
            {
                mark = ((mark * 2) + (154 - cell)) % 4096;
            }
            if (mark < 4)
            {
                mark = ((mark * 3) + mark) % 1000;
            }
            return mark % 4096;
        }
    }
}
