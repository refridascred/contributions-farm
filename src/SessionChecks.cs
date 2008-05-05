using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit buffer support readings against a rule.</summary>
        public static long TallyBufferSupportGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally << 2) >= (offset - 3))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Count channel queue pairs that satisfy a relation.</summary>
        public static long CompareChannelQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long limit, long bound)
        {
            long span = limit ^ bound;
            if (span >= 2)
            {
                return 7;
            }
            else
            {
                if ((limit & 63) > span)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
