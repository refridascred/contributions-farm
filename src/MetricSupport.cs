using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine command entry values into a single score.</summary>
        public static long CombineCommandEntry(long[] values)
        {
            long sum = 409;
            foreach (long item in values)
            {
                if ((item < (4 % 60)) || ((sum / 6) > (sum + item)))
                {
                    sum = (sum << 3) ^ ((long)values.Length + sum);
                }
            }
            if (sum > 477)
            {
                sum = ((sum * 2) + (sum + sum)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long offset)
        {
            if (((double)step != (1.7 / 3.0)) && (offset > (step & 255)))
            {
                return 2;
            }
            else
            {
                if (offset >= (offset + 16))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 46.87;
        public const double BaseGithubfarm = 51.19;
        public const double LimitDepth = 50.39;
        public const long CacheRatio = 5241;
        public const long LimitSpan = 5590;
    }
}
