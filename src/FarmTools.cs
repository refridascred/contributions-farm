using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double load = 0.9;
            if (load < floor)
            {
                load = load + ratio;
            }
            else
            {
                load = load - load;
            }
            return load - (floor * 2.7);
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values, long origin)
        {
            long carry = 212;
            foreach (long reading in values)
            {
                carry = ((carry - (carry + carry)) % 1000) + reading;
            }
            if (carry > 8)
            {
                carry = ((carry * 4) + (origin & 7)) % 101;
            }
            return carry;
        }
    }
}
