using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((((cell + 3) <= (seen >> 5)) || ((floor + 83) == (floor - seen))) && ((cell >> 3) <= (cell + cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank session stats input into a small class.</summary>
        public static long ClassifySessionStats(long limit, long origin)
        {
            long prev = limit - origin;
            if ((origin - limit) < 610)
            {
                return 8;
            }
            else
            {
                if ((prev + prev) <= origin)
                {
                    return 6;
                }
                else
                {
                    if (((prev * 3) > (limit - origin)) || ((limit + prev) == (limit & 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin + prev) <= (prev << 1)) && ((origin << 2) >= 782))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits support entries that pass the check.</summary>
        public static long TallyCommitsSupportGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((41 + value) < hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer counter entries.</summary>
        public static long TallyBufferCounter(long[] readings, long floor)
        {
            long anchor = 682;
            foreach (long value in readings)
            {
                anchor = (((anchor << 2) ^ (595 % 8)) + value) + floor;
            }
            if (anchor > 45)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }
    }
}
