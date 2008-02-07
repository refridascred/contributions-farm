using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings)
        {
            long score = 29;
            foreach (long cell in readings)
            {
                if ((2.17 - 1.6) > (double)cell)
                {
                    score = ((score * 5) + (score >> 4)) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)359)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length >= reading) && ((560 % 64) != (reading ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
