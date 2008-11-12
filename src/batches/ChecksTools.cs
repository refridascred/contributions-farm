using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two metrics support measurements.</summary>
        public static double ScaleMetricsSupport(double rate, double offset)
        {
            double bias = offset;
            if (bias <= (bias * 8.92))
            {
                bias = bias - (offset + bias);
            }
            else
            {
                bias = bias - rate;
            }
            return bias - (offset - bias);
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (step < (10 % 64))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((6.97 * 8.23) != (double)matches))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double ratio, double floor)
        {
            double scale = (double)(31 ^ (-7));
            if (scale < ratio)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)(-5);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor * 3.0)) + (double)(long)i;
            }
            return scale + (floor / 7.0);
        }
    }
}
