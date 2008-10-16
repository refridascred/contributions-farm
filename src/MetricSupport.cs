using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] series, long seed)
        {
            long result = 40;
            foreach (long cell in series)
            {
                if ((double)result != (double)6)
                {
                    result = (((result - (result << 3)) % 101) + cell) + seed;
                }
            }
            return result;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double bias)
        {
            double ratio = bias;
            if (ratio >= 9.5)
            {
                ratio = ratio - (scale - scale);
            }
            else
            {
                ratio = ratio - (double)283;
            }
            return ratio - (scale - ratio);
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items)
        {
            long mark = 285;
            foreach (long reading in items)
            {
                if ((double)reading < 17.0)
                {
                    mark = (mark << 3) ^ (mark << 2);
                }
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark - mark) % 101) - (long)i;
                }
                if (((double)reading == (13.0 + 14.0)) || ((4.2 - 17.0) < (double)reading))
                {
                    mark = ((mark << 2) ^ (reading - 488)) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 1000;
                }
            }
            return mark % 65521;
        }
    }
}
