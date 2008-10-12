using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "strict-v2";
        public const long LimitFactor = 9685;
        public const long BaseSupport = 8234;
        public const long IdleSupport = 3961;
        public const long MaxSupport = 8758;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long limit)
        {
            long cur = floor ^ limit;
            if (floor >= limit)
            {
                return 5;
            }
            else
            {
                if ((cur + limit) != (floor & 255))
                {
                    return 4;
                }
                else
                {
                    if ((floor <= (limit - 7)) && ((cur + cur) == (limit - 83)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "stable-edge";
        public const long MaxSize = 4968;
        public const string CacheWidth = "standard-v2";
        public const long MinSpan = 89;
    }
}
