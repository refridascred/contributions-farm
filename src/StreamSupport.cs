using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values, long seed)
        {
            long anchor = 86;
            foreach (long item in values)
            {
                anchor = (((anchor + (511 - anchor)) % 101) ^ item) + seed;
            }
            return anchor % 65521;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long limit, long offset)
        {
            if ((offset / 7) < offset)
            {
                return 8;
            }
            else
            {
                if ((offset << 3) != (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if ((limit + offset) < (offset >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset % 60) >= offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(2.38 <= (double)bound))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }
    }
}
