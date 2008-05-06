using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long offset2)
        {
            if ((double)offset2 <= 1.2)
            {
                return 6;
            }
            else
            {
                if (((offset + offset) > (9 << 1)) && (offset2 < (offset2 & 3)))
                {
                    return 1;
                }
                else
                {
                    if ((((-62) - offset2) >= offset2) && (offset <= (offset + offset2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((((origin + datum) >= (matches + origin)) || ((double)origin == (5.0 / 6.0))) || (3.16 > (double)datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double scale, double offset)
        {
            double load = offset;
            return (load + offset) + scale;
        }
    }
}
