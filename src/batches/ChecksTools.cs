using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen >= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                if (!((5 >> 2) >= (acc << 3)))
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) % 1000;
                }
                if (cell > (acc + cell))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double rate = 8.7;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (11.0 / 9.0)) + (double)(long)i) - span;
            }
            return rate - (scale * 2.41);
        }
    }
}
