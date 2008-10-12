using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every payload layout entry stays within the limit.</summary>
        public static bool ValidatePayloadLayoutRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
