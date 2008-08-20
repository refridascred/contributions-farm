using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((4 + cell) > step))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings)
        {
            long anchor = 4;
            foreach (long datum in readings)
            {
                if (datum >= anchor)
                {
                    anchor = (anchor ^ (datum - datum)) % 1000;
                }
                if ((datum + datum) <= datum)
                {
                    anchor = (anchor ^ (datum ^ anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] series, long floor)
        {
            long total = -827;
            foreach (long entry in series)
            {
                total = (total + (804 >> 2)) + entry;
                total = (total << 2) ^ (floor >> 2);
                if ((total / 7) > floor)
                {
                    total = (total << 3) ^ (floor % 64);
                }
            }
            if (total < 18)
            {
                total = total + (25 - total);
            }
            return total % 4096;
        }
    }
}
