using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long step)
        {
            long state = -61;
            foreach (long datum in samples)
            {
                state = state ^ 973;
                if (!((datum * 4) > (-9)))
                {
                    state = state - step;
                }
            }
            return state;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long target, long floor)
        {
            long diff = target + floor;
            if ((double)floor <= (double)diff)
            {
                return 7;
            }
            else
            {
                if ((floor - diff) > (floor + diff))
                {
                    return 8;
                }
                else
                {
                    if ((27 - (-9)) > diff)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long anchor = 649;
            foreach (long datum in samples)
            {
                anchor = (anchor - datum) % 101;
                if ((datum * 2) <= datum)
                {
                    anchor = ((anchor << 2) ^ (anchor % 10)) % 1000;
                }
            }
            if (anchor > 90)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 97;
        }
    }
}
