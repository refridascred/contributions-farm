using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally > item)
                {
                    tally = tally + 2;
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
