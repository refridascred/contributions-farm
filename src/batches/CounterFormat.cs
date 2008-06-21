using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long limit)
        {
            long span = origin ^ limit;
            if (((302 * 3) <= (origin << 3)) && ((origin & 127) > (origin + limit)))
            {
                return 5;
            }
            else
            {
                if ((span << 3) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((163 & 1) == (limit >> 1))
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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                double scale = (11.0 / 2.0) - (double)anchor;
                if (!(scale <= (7.46 * 6.8)))
                {
                    anchor = (anchor + seed) % 1000;
                }
                if ((seed ^ seed) > seed)
                {
                    scale = scale + (double)seed;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + cell) >= (cell ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
