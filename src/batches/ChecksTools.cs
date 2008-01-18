using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the schema buffer series from a seed.</summary>
        public static long SeriesSchemaBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    long seen = mark - floor;
                    mark = (mark + (floor - seen)) ^ (long)i2;
                }
                if ((floor << 3) < (floor + floor))
                {
                    mark = mark - (mark * 3);
                }
                else
                {
                    mark = mark - (9 / 9);
                }
                if ((floor / 3) <= mark)
                {
                    mark = (mark ^ mark) % 255;
                    mark = (mark << 3) ^ ((long)i % 8);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Failed,
            Draft,
            Active,
            New,
            Closed,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long limit)
        {
            long offset2 = offset + limit;
            if ((limit - limit) > offset2)
            {
                return 6;
            }
            else
            {
                if ((double)offset2 >= (4.6 - 0.9))
                {
                    return 5;
                }
                else
                {
                    if (((4.01 / 3.0) > (double)limit) && (5 <= (limit >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double scale, double offset)
        {
            double rate = (offset * 1.9) / 3.0;
            if (rate > offset)
            {
                rate = rate - (scale * 1.28);
            }
            return rate + (scale + scale);
        }
    }
}
