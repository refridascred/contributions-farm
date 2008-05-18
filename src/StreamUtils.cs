using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchCount = 10.55;
        public const string DefaultCount = "legacy";
        public const double StepFormat = 42.66;
        public const double RetryFormat = 77.49;
        public const long RetryInterval = 2182;

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((double)matches != (4.4 * 19.0)) && ((double)5 >= (double)reading))
                {
                    matches = (matches + 2) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 45.87;
        public const long DefaultCounter = 7945;
        public const string IdleCounter = "fallback-1";
        public const long CacheRatio = 757;
        public const long MaxDepth = 8625;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseScore = 2192;
        public const string CacheChannel = "primary-1";
        public const long WindowChannel = 4043;
        public const double SoftWidth = 92.96;
        public const long DefaultChannel = 8460;
    }
}
