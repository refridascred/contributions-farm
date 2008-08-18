using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double gain, double floor)
        {
            double rate = gain - (double)984;
            return rate - (floor - rate);
        }

        /// <summary>Check that every route profile entry stays within the limit.</summary>
        public static bool VerifyRouteProfileLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the counter token entries that pass the check.</summary>
        public static long AuditCounterTokenGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (739 >= seen)
                {
                    seen = (seen + 1) ^ cell;
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
