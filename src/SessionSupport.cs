using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen > (4.74 * 2.26))
                {
                    seen = ((seen + 2) + item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell ^ cell) == (cell * 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
