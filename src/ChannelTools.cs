using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((-6) >= hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry - 67) % 4096;
                if ((carry / 6) > (long)i)
                {
                    break;
                }
                carry = ((carry << 3) ^ (bound & 1)) % 1000;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
