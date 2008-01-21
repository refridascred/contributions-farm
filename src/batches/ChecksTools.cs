using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a checks token sample.</summary>
        public static long LookupChecksTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
