using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double rate, double bias)
        {
            double ratio = (double)(30 << 3);
            if (ratio <= bias)
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (rate - ratio)) + (double)(long)i;
            }
            return ratio - (19.0 * 1.38);
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double load = weight;
            return load + offset;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] readings, long step)
        {
            long mark = 634;
            foreach (long item in readings)
            {
                if ((item / 5) >= 568)
                {
                    mark = (mark + item) - step;
                }
            }
            if (mark > 73)
            {
                mark = (mark * 4) + mark;
            }
            return mark % 97;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
