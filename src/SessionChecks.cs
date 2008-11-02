using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((tally ^ datum) == (tally + seed)) || ((datum & 63) == (tally & 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Queued,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Measure how many counter schema samples are out of range.</summary>
        public static long TallyCounterSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits < (hits << 2))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value < (value << 2))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
