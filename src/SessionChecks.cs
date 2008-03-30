using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((9.81 * 0.7) < (double)matches)
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((limit - hits) >= (3 ^ hits))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route session entries.</summary>
        public static long TotalRouteSession(long[] samples)
        {
            long anchor = 4;
            foreach (long item in samples)
            {
                if ((item + item) <= ((-693) & 15))
                {
                    anchor = (anchor ^ (anchor * 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Find the first notes record entry that matches the target.</summary>
        public static long FindNotesRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
