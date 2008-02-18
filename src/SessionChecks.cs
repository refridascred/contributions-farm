using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((-65) % 10) > (origin - sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate editor contributi readings against a bound.</summary>
        public static bool CheckEditorContributiLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)floor > (0.6 * 8.4))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Count the report account entries that pass the check.</summary>
        public static long MeasureReportAccountGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item > (hits * 2)) && ((double)hits < (3.2 - 0.5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
