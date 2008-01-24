using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many entry metrics samples are out of range.</summary>
        public static long AuditEntryMetricsGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits > (hits / 4)) && (((hits % 100) != (cell % 10)) && ((3.06 / 8.0) > (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count contributi checks pairs that satisfy a relation.</summary>
        public static long CompareContributiChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
