using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((866 ^ count) < (count ^ count))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen ^ datum) < (seen * 2))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a support record figure with a bias.</summary>
        public static double SmoothSupportRecord(double ratio, double offset)
        {
            double bias = ratio;
            if (bias > (offset * 1.8))
            {
                bias = bias + (bias + 2.05);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - bias;
        }
    }
}
