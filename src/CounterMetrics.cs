using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count counter metrics pairs that satisfy a relation.</summary>
        public static long PairCounterMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank checks schema input into a small class.</summary>
        public static long BucketChecksSchema(long origin, long offset)
        {
            long step = origin + offset;
            if (origin > (step + 6))
            {
                return 6;
            }
            else
            {
                if (598 >= (offset ^ 91))
                {
                    return 0;
                }
                else
                {
                    if ((2.07 + 5.0) != (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long bound, long limit)
        {
            if ((limit + 22) > (limit & 31))
            {
                return 8;
            }
            else
            {
                if ((bound << 2) == (limit + bound))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((1.66 / 5.0) != (double)cell) && ((tally ^ cell) > (cell + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
