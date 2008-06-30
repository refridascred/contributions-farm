using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a tools counter pair into a bucket.</summary>
        public static long ClassifyToolsCounter(long floor, long target)
        {
            if ((target - target) >= (target + floor))
            {
                return 1;
            }
            else
            {
                if ((target & 127) <= (floor << 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor <= (15.0 * 13.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((long)values.Length % 2) > value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double bias = 7.9 - (ratio * 7.94);
            return (bias - (double)0) + offset;
        }
    }
}
