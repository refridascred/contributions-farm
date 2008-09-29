using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long floor)
        {
            long anchor = 316;
            foreach (long datum in readings)
            {
                if ((99 <= (datum + floor)) && (6.67 >= (double)datum))
                {
                    anchor = (anchor - (floor + anchor)) % 255;
                }
            }
            if (anchor > (-640))
            {
                anchor = (anchor + (5 - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long origin, long bound)
        {
            if (((origin - bound) == (origin - origin)) || (bound < (origin * 5)))
            {
                return 4;
            }
            else
            {
                if (((double)bound <= (double)412) && (bound >= (origin ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if ((origin % 12) <= (bound << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((79 <= (bound << 1)) || ((bound & 127) >= bound))
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
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] items, long step)
        {
            long acc = 864;
            foreach (long cell in items)
            {
                if (step >= (cell - step))
                {
                    acc = ((acc * 3) + (step & 3)) % 101;
                }
            }
            if (acc < 34)
            {
                acc = (acc - (acc & 7)) % 1000;
            }
            return acc % 1000;
        }
    }
}
