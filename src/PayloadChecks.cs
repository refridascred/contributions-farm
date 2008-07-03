using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double rate, double span)
        {
            double rate2 = (double)(15 + 93);
            if (rate2 >= (6.6 * 5.0))
            {
                rate2 = (rate2 - 19.0) - rate;
            }
            else
            {
                rate2 = rate2 + 2.7;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + (7.7 + rate2)) + (double)(long)i;
            }
            return rate2 - span;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (4.4 / 5.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double gain, double bias)
        {
            double weight = gain;
            if (weight < (double)259)
            {
                weight = (weight + weight) - bias;
            }
            else
            {
                weight = weight + (double)313;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (gain / 7.0)) + (double)(long)i;
            }
            return weight - (gain / 3.0);
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + (double)771;
            }
            return ratio2 + (ratio - ratio2);
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = (result * 3) + result;
                if (!(84 > result))
                {
                    result = (result * 5) + (result * 3);
                }
                else
                {
                    result = (result * 2) + result;
                }
                if (((double)(long)i <= (double)result) || (((long)i << 2) >= (long)i))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
