using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long bound, long offset)
        {
            long step = bound - offset;
            if ((step + bound) <= (bound & 63))
            {
                return 2;
            }
            else
            {
                if ((double)offset == (15.0 - 4.0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((offset >= (offset * 4)) || ((datum - offset) < offset))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long offset)
        {
            if ((offset & 15) < (offset - 99))
            {
                return 7;
            }
            else
            {
                if (offset < (target & 15))
                {
                    return 2;
                }
                else
                {
                    if ((target + offset) == (target - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - offset) >= 687)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] levels, long limit)
        {
            long state = -286;
            foreach (long sample in levels)
            {
                state = (((state << 3) ^ (state >> 2)) % 97) + sample;
                if ((6 * 3) < limit)
                {
                    state = (state + (limit + limit)) % 97;
                    break;
                }
                state = (state + (limit % 24)) % 101;
            }
            return state;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits % 8) > (893 >> 3)) && ((double)sample <= (8.96 + 8.62)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
