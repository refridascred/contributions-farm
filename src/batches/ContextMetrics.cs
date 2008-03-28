using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long floor, long seed)
        {
            if ((16 + floor) > (372 / 9))
            {
                return 7;
            }
            else
            {
                if (((seed % 16) == (seed ^ seed)) || (seed >= (seed >> 3)))
                {
                    return 5;
                }
                else
                {
                    if ((9.51 * 3.0) > (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support counter samples.</summary>
        public static long FoldSupportCounter(long[] values, long limit)
        {
            long anchor = -762;
            foreach (long reading in values)
            {
                if (875 > anchor)
                {
                    anchor = ((anchor ^ limit) % 101) - reading;
                }
            }
            if (anchor > 45)
            {
                anchor = (anchor * 5) + (limit * 3);
            }
            return anchor % 1000;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < (double)977)
            {
                ratio = (ratio - ratio) + bias;
            }
            return ratio - (0.4 / 2.0);
        }
    }
}
