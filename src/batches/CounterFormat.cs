using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count layout commits pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit report tools readings against a rule.</summary>
        public static long CountReportToolsMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((331 ^ limit) <= (reading + limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
