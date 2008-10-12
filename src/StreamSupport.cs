using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the account session entries that pass the check.</summary>
        public static long TallyAccountSessionGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((10.0 - 6.5) == (double)hits)
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double offset)
        {
            double gain2 = (double)(-595) * 7.58;
            if (gain2 >= (gain + gain2))
            {
                gain2 = gain2 + 9.0;
            }
            else
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (1.53 + offset);
        }
    }
}
