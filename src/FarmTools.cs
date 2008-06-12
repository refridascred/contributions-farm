using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a stats farm figure with a bias.</summary>
        public static double SmoothStatsFarm(double scale, double span)
        {
            double mean = scale;
            if (mean <= (scale * 10.0))
            {
                mean = mean - span;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + 6.11;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((3.3 / 6.0) <= (double)seen)
                {
                    seen = (seen + 3) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
