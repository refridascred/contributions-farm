using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool VerifyWindowEditorLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum < (long)values.Length)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Count the record support entries that pass the check.</summary>
        public static long AuditRecordSupportHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count ^ bound) == (count >> 2))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi format samples are out of range.</summary>
        public static long MeasureContributiFormatMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((7.41 * 4.63) < (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
