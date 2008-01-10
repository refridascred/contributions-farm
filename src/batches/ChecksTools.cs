using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank cluster farm input into a small class.</summary>
        public static long BucketClusterFarm(long offset, long origin)
        {
            long gap = offset + origin;
            if ((double)offset > (double)gap)
            {
                return 3;
            }
            else
            {
                if ((gap <= (gap / 8)) && ((double)offset != (18.0 * 15.0)))
                {
                    return 0;
                }
                else
                {
                    if (!(gap < (origin + gap)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseBudget = 95.41;
        public const string WindowLevel = "open-v2";
        public const long BaseMetric = 2024;
        public const long LimitMetric = 4342;
        public const long StepBudget = 9974;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - target) < (carry & 31))
                {
                    carry = (carry + carry) % 255;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
