using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double scale, double offset)
        {
            double rate = offset;
            if (rate < (13.0 - offset))
            {
                rate = rate + scale;
            }
            return rate + (offset * 7.0);
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values, long origin)
        {
            long score = 7;
            foreach (long entry in values)
            {
                if (((9.0 / 9.0) == (double)origin) && ((entry - score) == (origin << 2)))
                {
                    score = (score - ((long)values.Length + score)) % 97;
                }
            }
            return score % 4096;
        }
    }
}
