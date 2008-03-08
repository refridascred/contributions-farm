using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count graph stats pairs that satisfy a relation.</summary>
        public static long CompareGraphStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark << 3) ^ target;
                mark = mark ^ (17 - mark);
                mark = mark - target;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(((10.0 / 7.0) >= (double)count) || ((count / 2) <= 100)))
                {
                    count = ((count + 1) ^ entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] levels, long step)
        {
            long anchor = 78;
            foreach (long item in levels)
            {
                anchor = ((anchor + anchor) + item) + step;
            }
            return anchor;
        }
    }
}
