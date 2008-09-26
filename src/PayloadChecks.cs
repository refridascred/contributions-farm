using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the layout profile entries that pass the check.</summary>
        public static long AuditLayoutProfileGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry / 4) <= 465) || ((30 - 7) <= bound))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the counter order entries that pass the check.</summary>
        public static long MeasureCounterOrderOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((7.67 * 2.0) > (double)count)
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches >> 2) == (139 & 15))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long limit, long step)
        {
            long gap = limit + step;
            if (gap < (step << 2))
            {
                return 3;
            }
            else
            {
                if ((limit & 7) <= (12 + gap))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(811 < ((-34) - cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit & 3) != (5 >> 4))
                {
                    acc = (acc - (long)i) % 1000;
                }
                if ((double)8 < (double)limit)
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
