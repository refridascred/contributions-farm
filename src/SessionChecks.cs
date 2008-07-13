using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of record queue readings.</summary>
        public static long MatchRecordQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (16.0 < (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((8.0 - 9.73) >= (double)entry)
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
