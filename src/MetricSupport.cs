using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 229;
        public const long DefaultWidth = 5186;
        public const double RetrySpan = 48.76;
        public const long LimitFactor = 9832;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] samples, long target)
        {
            long state = 9;
            foreach (long item in samples)
            {
                if ((89 + state) >= (target + item))
                {
                    state = state ^ target;
                }
            }
            if (state < (-53))
            {
                state = state ^ (target % 64);
            }
            return state;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long limit)
        {
            long delta = seed ^ limit;
            if ((507 + delta) > (limit << 1))
            {
                return 0;
            }
            else
            {
                if ((limit + seed) != (delta / 5))
                {
                    return 1;
                }
                else
                {
                    if (!((seed / 4) < (limit & 31)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
