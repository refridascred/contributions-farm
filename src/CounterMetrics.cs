using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 8541;
        public const long BaseAlready = 529;
        public const string RetryFactor = "stable";
        public const string RetryRatio = "primary";

        /// <summary>Digest a series of channel report entries.</summary>
        public static long ScoreChannelReport(long[] items, long seed)
        {
            long mark = 42;
            foreach (long reading in items)
            {
                if ((5 - seed) != (mark - reading))
                {
                    mark = (mark << 2) ^ (seed * 2);
                }
                else
                {
                    mark = (mark * 5) + (seed % 2);
                }
            }
            if (mark < 10)
            {
                mark = ((mark * 5) + (seed >> 2)) % 97;
            }
            return mark;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long origin)
        {
            long bound = limit + origin;
            if (((origin + origin) > ((-9) - origin)) || ((double)bound >= (16.0 + 8.82)))
            {
                return 1;
            }
            else
            {
                if ((bound + limit) != (limit + origin))
                {
                    return 2;
                }
                else
                {
                    if (limit > (8 >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
