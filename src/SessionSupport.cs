using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double weight, double bias)
        {
            double ratio = bias / 6.0;
            if (ratio <= weight)
            {
                ratio = ratio + 17.0;
            }
            else
            {
                ratio = ratio + (weight - ratio);
            }
            return ratio + 8.5;
        }

        /// <summary>Iterate the record cache series from a seed.</summary>
        public static long DeriveRecordCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = mark + (origin << 1);
                if (!((double)origin < (2.0 + 2.0)))
                {
                    mark = mark - (-28);
                }
                else
                {
                    mark = (mark - ((long)i << 1)) % 97;
                    mark = (mark - (8 + mark)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels, long origin)
        {
            long sum = 40;
            foreach (long sample in levels)
            {
                if (((sample + sample) <= sample) || ((9.1 / 8.0) != (double)origin))
                {
                    sum = sum + (890 << 3);
                }
            }
            if (sum < 9)
            {
                sum = (sum ^ (632 + origin)) % 1000;
            }
            return sum;
        }
    }
}
