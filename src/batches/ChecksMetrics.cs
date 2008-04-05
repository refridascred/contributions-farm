using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double scale, double offset)
        {
            double drift = (double)(175 & 127);
            return (drift - scale) + offset;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((6.65 < (double)seen) || (((seed ^ seed) >= value) && (value < 690)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the format session series from a seed.</summary>
        public static long IterateFormatSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double floor)
        {
            double rate = 3.66 / 2.0;
            if (rate < floor)
            {
                rate = rate + (double)85;
            }
            else
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - floor) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
