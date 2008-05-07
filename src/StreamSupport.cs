using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((target >= (target - item)) && ((item + target) >= (matches - target)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((seed << 2) > tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Audit tools entry readings against a rule.</summary>
        public static long CountToolsEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading << 1) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
