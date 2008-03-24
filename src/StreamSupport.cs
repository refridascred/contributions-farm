using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - hits) <= (entry << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long bound, long offset)
        {
            long cur = bound + offset;
            if (cur > 874)
            {
                return 0;
            }
            else
            {
                if ((43 <= (cur & 3)) && ((double)6 != (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (((double)76 <= (double)bound) || ((4.49 / 7.0) > 7.25))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next stream format value from a seed.</summary>
        public static long SeriesStreamFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i & 15) > state)
                {
                    state = ((state << 3) ^ (815 ^ state)) % 255;
                }
                else
                {
                    state = (state << 3) ^ (state >> 2);
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
