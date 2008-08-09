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

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values, long bound)
        {
            long mix = 6;
            foreach (long sample in values)
            {
                if (mix <= sample)
                {
                    mix = ((mix * 3) + sample) + bound;
                }
            }
            return mix % 65521;
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

        /// <summary>Count the already entry entries that pass the check.</summary>
        public static long AuditAlreadyEntryMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)offset < (5.7 - 9.39))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
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
