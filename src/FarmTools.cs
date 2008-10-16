using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the route support entries that pass the check.</summary>
        public static long CountRouteSupportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((double)973 <= (double)matches) || ((entry + 55) < matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = carry ^ (target ^ (long)i);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Dropped,
            Retry,
            Stale,
        }
    }
}
