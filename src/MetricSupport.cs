using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally / 6) == (tally << 2))
                {
                    tally = ((tally + 2) ^ item) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((entry % 2) <= (5 + entry)) || (seed < (seed - (long)data.Length))) && ((85 + 6) <= ((long)data.Length + seed)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
