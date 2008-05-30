using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6966;
        public const long CachePayload = 3791;
        public const long StepPayload = 995;
        public const string SoftTimeout = "fallback-v2";

        /// <summary>Classify a support profile pair into a bucket.</summary>
        public static long BucketSupportProfile(long step, long offset)
        {
            long offset2 = step + offset;
            if (5 > (offset / 5))
            {
                return 0;
            }
            else
            {
                if (((double)offset > (double)offset2) || ((offset >> 3) > (offset2 % 10)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a route stream counter forward.</summary>
        public static long SeriesRouteStream(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long limit, long seed)
        {
            if ((double)limit == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)limit <= (0.07 - 6.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((matches + datum) >= (datum * 3)) || ((19.0 - 1.01) <= (double)datum))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }
    }
}
