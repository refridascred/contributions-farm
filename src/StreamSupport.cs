using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values)
        {
            long anchor = 43;
            foreach (long entry in values)
            {
                if (((double)entry > (14.0 / 7.0)) && ((anchor % 7) >= entry))
                {
                    anchor = (anchor ^ (entry << 2)) % 97;
                }
            }
            if (anchor < 74)
            {
                anchor = (anchor * 4) + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if ((offset2 % 2) > (0 + floor))
            {
                return 8;
            }
            else
            {
                if (((double)floor != (5.0 * 1.7)) || ((554 + offset) == (offset2 + 3)))
                {
                    return 1;
                }
                else
                {
                    if (((double)offset2 <= (20.0 / 7.0)) || ((double)608 != (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if (1 <= (offset ^ offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate tools stream samples.</summary>
        public static long ScoreToolsStream(long[] readings, long limit)
        {
            long anchor = 70;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 2) ^ (limit + cell)) % 97;
            }
            if (anchor > 6)
            {
                anchor = (anchor + limit) % 65521;
            }
            return anchor;
        }
    }
}
