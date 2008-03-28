using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseTimeout = 3300;
        public const double DefaultContributi = 16.71;
        public const double LimitContributi = 46.71;

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

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long target)
        {
            if ((step & 31) >= 575)
            {
                return 8;
            }
            else
            {
                if ((target >= (step & 31)) || ((double)step > (4.72 / 6.0)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double span)
        {
            double bias = (gain / 8.0) * 0.4;
            if (bias <= (double)951)
            {
                bias = (bias - gain) - span;
            }
            return bias + (gain + 11.0);
        }

        /// <summary>Scale a cluster stream figure with a bias.</summary>
        public static double BlendClusterStream(double ratio, double span)
        {
            double drift = span;
            return (drift - span) + ratio;
        }
    }
}
