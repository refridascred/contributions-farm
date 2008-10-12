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

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long step, long offset)
        {
            long diff = step - offset;
            if ((offset - diff) > diff)
            {
                return 5;
            }
            else
            {
                if ((1.7 - 3.77) <= (double)diff)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
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
