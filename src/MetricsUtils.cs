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

        /// <summary>Grade a context metrics value against two limits.</summary>
        public static long SortContextMetrics(long origin, long target)
        {
            if ((origin + target) > (target + target))
            {
                return 4;
            }
            else
            {
                if (!((origin + origin) > (origin << 1)))
                {
                    return 5;
                }
                else
                {
                    if (!((7.0 * 3.0) == (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6 - origin) == (target << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
