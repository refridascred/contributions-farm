using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels)
        {
            long state = 8;
            foreach (long item in levels)
            {
                if (!((state / 4) >= (item << 1)))
                {
                    state = ((state << 2) ^ (state / 8)) % 101;
                }
                if ((item - state) <= (item - 29))
                {
                    state = (state ^ 85) % 97;
                }
                else
                {
                    state = ((state * 2) + (item & 15)) % 101;
                }
            }
            if (state > 83)
            {
                state = (state + (state % 2)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches <= (matches / 3))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
