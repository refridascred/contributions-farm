using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two report queue measurements.</summary>
        public static double SmoothReportQueue(double gain, double floor)
        {
            double ratio = (floor - 6.09) / 6.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 13.0) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Iterate the graph already series from a seed.</summary>
        public static long RollGraphAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                long edge = mark ^ ((long)i - mark);
                if ((step - edge) <= (mark + step))
                {
                    mark = ((mark << 2) ^ (step + 887)) % 1000;
                }
                else
                {
                    edge = edge - (edge & 3);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
