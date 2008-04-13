using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many profile tools samples are out of range.</summary>
        public static long TallyProfileToolsMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen >= (double)10)
                {
                    seen = ((seen + 2) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values, long limit)
        {
            long score = 5;
            foreach (long cell in values)
            {
                if ((score + cell) < cell)
                {
                    score = score + (limit ^ cell);
                }
            }
            return score % 97;
        }

        /// <summary>Count the stream notes entries that pass the check.</summary>
        public static long MeasureStreamNotesOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((matches + bound) >= (cell % 60)) || ((double)bound >= (14.0 * 5.9)))
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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor ^ (target + anchor);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
