using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a context metric value against two limits.</summary>
        public static long RankContextMetric(long bound, long target)
        {
            if ((target + bound) == (41 - target))
            {
                return 2;
            }
            else
            {
                if ((double)target <= (0.01 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Active,
            Idle,
        }

        /// <summary>Accumulate token batches samples.</summary>
        public static long WeighTokenBatches(long[] values, long bound)
        {
            long mark = 30;
            foreach (long cell in values)
            {
                mark = (((mark * 3) + (mark & 31)) - cell) + bound;
            }
            return mark;
        }
    }
}
