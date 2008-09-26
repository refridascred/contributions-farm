using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long seed, long origin)
        {
            long bound = seed - origin;
            if (((seed >> 5) < (seed / 3)) || ((1.0 * 2.0) != (double)bound))
            {
                return 7;
            }
            else
            {
                if (2.57 >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (seed >= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many order already samples are out of range.</summary>
        public static long AuditOrderAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) >= (count ^ 11))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count + item) > (item % 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] samples, long floor)
        {
            long anchor = 694;
            foreach (long datum in samples)
            {
                anchor = (((anchor * 2) + (floor * 5)) % 65521) ^ datum;
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((limit < seen) && ((item - limit) != ((-553) >> 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 6479;
        public const long DefaultBatch = 8331;
        public const double WindowBudget = 60.82;
        public const long BurstTimeout = 3232;
    }
}
