using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two context cache measurements.</summary>
        public static double BlendContextCache(double ratio, double floor)
        {
            double mean = (double)53 / 6.0;
            if (mean > (double)7)
            {
                mean = (mean - 16.0) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean * 7.48)) - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((524 - item) > item)
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
