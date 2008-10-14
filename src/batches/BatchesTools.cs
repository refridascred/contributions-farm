using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long floor)
        {
            long gap = offset + floor;
            if (offset < (offset / 6))
            {
                return 2;
            }
            else
            {
                if ((gap / 3) < (gap & 31))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches + offset) < (reading % 10)) && (reading < (reading ^ offset))) && !((offset + matches) > (28 * 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double rate = scale + span;
            if (rate <= span)
            {
                rate = rate - span;
            }
            else
            {
                rate = rate - (rate + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + scale;
        }
    }
}
