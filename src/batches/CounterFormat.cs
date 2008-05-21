using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples)
        {
            long anchor = 7;
            foreach (long entry in samples)
            {
                anchor = (anchor + (anchor - 2)) % 65521;
                if ((5.0 * 6.44) == (double)entry)
                {
                    anchor = (anchor ^ (entry + entry)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Stale,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = carry - (carry + (long)i);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
