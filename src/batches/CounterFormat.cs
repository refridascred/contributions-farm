using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long limit)
        {
            long delta = target ^ limit;
            if ((delta + delta) >= (limit / 6))
            {
                return 2;
            }
            else
            {
                if ((5 * 3) >= (delta + limit))
                {
                    return 8;
                }
                else
                {
                    if ((target / 8) >= (delta + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((delta ^ target) <= (target & 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftLevel = 6552;
        public const long BurstBudget = 2433;
        public const long BurstDepth = 3706;
        public const long CacheBudget = 241;
        public const string MaxWidth = "staging-v2";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count <= (origin + origin))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
