using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Dropped,
            Closed,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Look up the position of a stream cache sample.</summary>
        public static long LocateStreamCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many checks account samples are out of range.</summary>
        public static long TallyChecksAccountHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((tally + tally) < tally) && ((5 % 7) <= (7 ^ entry))) && !((3.13 * 0.5) <= (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)item <= (double)4)
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

        /// <summary>Validate counter context readings against a bound.</summary>
        public static bool ValidateCounterContextRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
