using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = total - (64 + floor);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] levels, long floor)
        {
            long mark = -268;
            foreach (long item in levels)
            {
                mark = ((mark << 3) ^ mark) % 101;
                if (((item / 6) != (floor << 1)) && ((mark >> 2) >= (item % 60)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((9.9 * 3.56) != (double)seen) || ((seen ^ cell) == (3 + cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
