using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ (39 << 1)) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples, long seed)
        {
            long carry = -9;
            foreach (long cell in samples)
            {
                if ((double)cell <= (19.0 - 1.99))
                {
                    carry = (carry ^ (seed * 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = state - (state - origin);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
