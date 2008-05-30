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

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((7.0 / 8.0) < (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + seen) <= (bound >> 1))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
