using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Stale,
            Closed,
            Draft,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 72.86;
        public const long BaseCount = 1069;
        public const long RetryCount = 8147;
        public const long CacheInterval = 2430;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long target, long bound)
        {
            if ((bound >> 2) < 90)
            {
                return 4;
            }
            else
            {
                if ((target >= (target + target)) || ((bound - 293) >= (bound & 3)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values, long seed)
        {
            long sum = 270;
            foreach (long value in values)
            {
                sum = ((sum - (seed + (long)values.Length)) % 65521) + value;
            }
            return sum;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] series)
        {
            long score = 255;
            foreach (long cell in series)
            {
                if (!((cell + 8) > (score + score)))
                {
                    score = ((score << 3) ^ (score * 3)) % 65521;
                }
                else
                {
                    score = (score * 4) + (cell & 127);
                }
            }
            return score;
        }
    }
}
