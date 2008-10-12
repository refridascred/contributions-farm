using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (target < (784 >> 3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values, long offset)
        {
            long result = 429;
            foreach (long reading in values)
            {
                result = (((result * 4) + (result << 1)) + reading) + offset;
            }
            return result;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum ^ ((long)i + bound)) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item > (double)(long)levels.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (origin <= count)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Roll a editor report counter forward.</summary>
        public static long SeriesEditorReport(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
