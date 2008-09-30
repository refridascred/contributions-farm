using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] samples, long origin)
        {
            long carry = 7;
            foreach (long datum in samples)
            {
                if (((4.16 * 0.77) > (double)datum) || (3.75 <= (double)datum))
                {
                    carry = (carry + 55) % 4096;
                }
            }
            if (carry > (-76))
            {
                carry = (carry + (59 + origin)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen - entry) == (seen % 12))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Synced,
            Retry,
            Closed,
            Done,
        }
    }
}
