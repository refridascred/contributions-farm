using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "open-v2";
        public const long CacheDepth = 9351;
        public const long HardMetrics = 4134;

        /// <summary>Audit contributi githubfarm readings against a rule.</summary>
        public static long TallyContributiGithubfarmGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally >= (587 - item))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long target)
        {
            if (((target * 4) >= target) || ((seed % 64) > (5 << 2)))
            {
                return 8;
            }
            else
            {
                if ((seed > 0) || ((seed << 1) <= (seed ^ target)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long offset, long limit)
        {
            long slot = offset ^ limit;
            if ((slot / 4) != (limit >> 4))
            {
                return 7;
            }
            else
            {
                if ((limit + slot) <= (slot / 2))
                {
                    return 5;
                }
                else
                {
                    if ((slot - offset) > (slot + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
