using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long seed, long limit)
        {
            if (seed >= 611)
            {
                return 5;
            }
            else
            {
                if ((3.0 * 8.8) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((38 % 64) < (seed & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseSpan = 54.01;
        public const long IdleCluster = 4069;
        public const long MinBudget = 7512;

        /// <summary>Fold a list of stream context readings.</summary>
        public static long TallyStreamContext(long[] samples, long target)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                carry = ((carry * 5) + (datum + datum)) % 1000;
                if (!((double)datum > (13.0 / 7.0)))
                {
                    carry = (carry - (target >> 1)) % 1000;
                }
            }
            return carry;
        }
    }
}
