using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Active,
            Failed,
            Dropped,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((-913) + 24) < matches)
                {
                    matches = ((matches + 2) ^ item) + target;
                }
            }
            return matches;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((((8.06 / 6.0) == (double)reading) || ((tally * 2) <= (origin / 4))) || ((reading % 100) > (7 + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen * 2) == (seen + datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
