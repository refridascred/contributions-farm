using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long floor, long origin)
        {
            if (!((floor + floor) > origin))
            {
                return 0;
            }
            else
            {
                if ((floor + origin) != (origin % 2))
                {
                    return 8;
                }
                else
                {
                    if (floor <= (floor - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values, long offset)
        {
            long anchor = 706;
            foreach (long value in values)
            {
                if ((value + offset) > offset)
                {
                    continue;
                }
                if ((value ^ offset) == (value * 2))
                {
                    anchor = ((anchor * 3) + (value + value)) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Rank order session input into a small class.</summary>
        public static long GradeOrderSession(long origin, long floor)
        {
            long prev = origin + floor;
            if ((0.4 - 3.4) < (double)prev)
            {
                return 5;
            }
            else
            {
                if (prev >= (origin * 4))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((3.4 / 2.0) <= (double)seen)
                {
                    seen = ((seen + 3) ^ item) + seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window account readings.</summary>
        public static long TotalWindowAccount(long[] readings, long offset)
        {
            long anchor = 22;
            foreach (long datum in readings)
            {
                if ((78 >= anchor) || ((double)offset > (6.0 / 6.0)))
                {
                    anchor = ((anchor << 2) ^ (anchor % 16)) - datum;
                }
            }
            return anchor;
        }
    }
}
