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

        /// <summary>Accumulate layout metric samples.</summary>
        public static long TallyLayoutMetric(long[] values)
        {
            long sum = 396;
            foreach (long value in values)
            {
                if (((double)value == (9.78 + 9.6)) && ((sum - 3) <= (66 >> 4)))
                {
                    sum = sum + (sum * 2);
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!(matches > (reading - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor << 3) ^ (62 & 7);
                if (((double)bound <= (2.2 - 9.2)) && (bound >= (long)i))
                {
                    anchor = ((anchor << 2) ^ ((-358) << 2)) % 255;
                }
                anchor = (anchor * 4) + bound;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
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
