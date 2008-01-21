using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many schema entry samples are out of range.</summary>
        public static long CountSchemaEntryGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((reading - offset) != (hits - offset)) && ((offset >= reading) || (reading < (offset + 736))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Count cache window pairs that satisfy a relation.</summary>
        public static long OverlapCacheWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
