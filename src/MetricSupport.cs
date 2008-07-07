using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit checks githubfarm readings against a rule.</summary>
        public static long AuditChecksGithubfarmHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - tally) <= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
