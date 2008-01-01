using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry << 2) ^ (carry << 3);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long MeasureCommandFarmOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((4.13 / 5.0) >= (double)cell) || ((double)target >= (0.09 / 2.0)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Pending,
            Queued,
        }
    }
}
