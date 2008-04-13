using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a entry payload value against two limits.</summary>
        public static long BucketEntryPayload(long offset, long origin)
        {
            if ((origin + offset) < offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset <= 7.2)
                {
                    return 0;
                }
                else
                {
                    if (((origin + origin) >= origin) || ((double)offset >= (3.0 / 5.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally << 1) != (entry + tally)) && ((tally >> 5) == (34 + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((matches >> 4) <= (entry + matches)) || ((double)matches < (double)2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] items)
        {
            long score = 567;
            foreach (long cell in items)
            {
                score = score - (cell / 4);
                if ((cell * 2) <= (cell + (-1)))
                {
                    score = (score - (563 & 3)) % 65521;
                }
                else
                {
                    score = (score - (score + score)) % 4096;
                }
            }
            return score;
        }
    }
}
