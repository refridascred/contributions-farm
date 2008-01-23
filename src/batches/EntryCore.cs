using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double scale, double offset)
        {
            double scale2 = scale * 2.4;
            if (scale2 > (offset + offset))
            {
                scale2 = scale2 - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - scale) + (double)(long)i;
            }
            return scale2 + (double)6;
        }

        /// <summary>Measure how many payload counter samples are out of range.</summary>
        public static long CountPayloadCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading - (-635)) <= (reading << 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a route schema sample.</summary>
        public static long LookupRouteSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a notes window counter forward.</summary>
        public static long RollNotesWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ (limit + acc);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)origin > (9.26 + 8.5))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
