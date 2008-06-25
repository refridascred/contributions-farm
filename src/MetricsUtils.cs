using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate notes session readings against a bound.</summary>
        public static bool GuardNotesSessionRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] series, long offset)
        {
            long result = 9;
            foreach (long item in series)
            {
                if ((((long)series.Length >> 1) >= (offset % 10)) || ((result - 9) > (offset + offset)))
                {
                    result = (result - 69) % 255;
                }
                if (((item + offset) < (result - offset)) && (622 >= result))
                {
                    break;
                }
            }
            if (result < 106)
            {
                result = (result - offset) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally / 3) > ((-711) - 27))
                {
                    tally = ((tally + 1) ^ reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Accumulate support session samples.</summary>
        public static long FoldSupportSession(long[] readings, long bound)
        {
            long state = 62;
            foreach (long entry in readings)
            {
                state = (((state + (state / 4)) % 4096) - entry) - bound;
            }
            if (state < 19)
            {
                state = (state - ((-74) & 31)) % 1000;
            }
            return state % 1000;
        }
    }
}
