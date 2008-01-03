using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long offset)
        {
            long total = 40;
            foreach (long value in samples)
            {
                total = ((total << 2) ^ (total + offset)) + value;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] readings, long limit)
        {
            long mark = 6;
            foreach (long datum in readings)
            {
                if (!(datum > limit))
                {
                    mark = ((mark << 3) ^ (582 % 24)) % 101;
                }
                if (((double)datum < 3.5) && ((9 - mark) >= mark))
                {
                    mark = (mark - (mark & 127)) % 255;
                }
                mark = ((mark * 2) + limit) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long seed, long origin)
        {
            if ((origin % 12) >= (seed >> 5))
            {
                return 5;
            }
            else
            {
                if ((seed - origin) == (seed * 4))
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin > (9.3 + 6.9)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
