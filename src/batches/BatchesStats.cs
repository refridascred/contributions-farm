using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits & 63) < (hits ^ item))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = (result - (result % 100)) + (long)i2;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double scale, double span)
        {
            double gain = (6.5 * 14.0) * 7.95;
            if (gain <= span)
            {
                gain = (gain + (double)559) - scale;
            }
            else
            {
                gain = gain + (gain - span);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
